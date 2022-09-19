using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImportDBToCSV.ExtendedClasses
{
    public  class DAL
    {
        public string ConnectionString = ConfigurationManager.AppSettings["DBConnection"];
        public string FileDelimiter = ";";
        
      
        private bool firstRowContainsFieldNames = false;


        public DataTable GetData()
        {
            using (SqlConnection SQLConnection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT InputData_table.CustomerId 
                                ,InputData_table.CustomerName
                                ,InputData_table.Notes
                                ,Code_lookup_table.Code_name
                              FROM InputData_table
                            LEFT JOIN Code_lookup_table on InputData_table.CodeId = Code_lookup_table.Code_ID";
                using (SqlCommand cmd = new SqlCommand(query, SQLConnection))
                {
                    SQLConnection.Open();
                    var dtable = new DataTable();
                    dtable.Load(cmd.ExecuteReader());
                    SQLConnection.Close();
                    return dtable;
                    
                }
            }
            
        }

        public bool CreateCSV(DataTable dt, string filename)
        {
            string FileFullPath = ConfigurationManager.AppSettings["Path"] + filename + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            try
            {

               
                StreamWriter sw = null;
                sw = new StreamWriter(FileFullPath, false);

                // Write the Header Row to File
                int ColumnCount = dt.Columns.Count;
                for (int ic = 0; ic < ColumnCount; ic++)
                {
                    sw.Write(dt.Columns[ic]);
                    if (ic < ColumnCount - 1)
                    {
                        sw.Write(FileDelimiter);
                    }
                }
                sw.Write(FileDelimiter);
                sw.Write("Date_last_Export");
                sw.Write(sw.NewLine);

                // Write All Rows to the File
                foreach (DataRow dr in dt.Rows)
                {
                    for (int ir = 0; ir < ColumnCount; ir++)
                    {
                        if (!Convert.IsDBNull(dr[ir]))
                        {
                            sw.Write(dr[ir].ToString());
                        }
                        if (ir < ColumnCount - 1)
                        {
                           
                            sw.Write(FileDelimiter);
                           
                        }
                       
                    }
                    sw.Write(FileDelimiter);
                    sw.Write(DateTime.Now.ToString());
                    sw.Write(sw.NewLine);

                }

                sw.Close();


                Logger.Log.Info($"{DateTime.Now},  CSV with name {FileFullPath} is imported");
                return true;
            }
            catch(Exception ex)
            {
                Logger.Log.Error($"{DateTime.Now},  CSV with name {FileFullPath} is not imported");
                throw new Exception(ex.Message);
            }
          
        }

        private DataTable ReadCSV(string filename)
        {
            DataTable result = new DataTable();
            string FilePath = ConfigurationManager.AppSettings["Path"] + filename+".csv";
            if (FilePath == "")
            {
                return result;
            }

            string delimiters = ";";
                   

            using (TextFieldParser tfp = new TextFieldParser(FilePath))
            {
                tfp.SetDelimiters(delimiters);


                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                            result.Columns.Add(fields[i]);
                        else
                            result.Columns.Add("Col" + i);
                    }


                    if (!firstRowContainsFieldNames)
                    {
                      
                        result.Rows.Add(fields);
                    }
                }


                while (!tfp.EndOfData)
                    result.Rows.Add(tfp.ReadFields());
            }

            return result;
        }

        public bool LoadDataToSql(string filename)
        {
            var dt = ReadCSV(filename);
            var result = false;
            ClearTable();
            var csvCount = dt.Rows.Count;
            var sqlstring = @"INSERT INTO [dbo].[InputData_table]
                               ([CustomerId]
                               ,[CustomerName]
                               ,[Notes]
                               ,[CodeId])
                         VALUES
                               (
                                @CustomerId
                               , @CustomerName
                               , @Notes
                               , @CodeId)";
            var sqlCount = 0;
            foreach (DataRow objRow in dt.Rows)
            {
                try
                {
                    using (var sqlLConnection = new SqlConnection(ConnectionString))
                    {
 
                        using (SqlCommand cmd = new SqlCommand(sqlstring, sqlLConnection))
                        {
                            sqlLConnection.Open();
                            cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = Convert.ToInt32(objRow[0]);
                            cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = objRow[1].ToString();
                            cmd.Parameters.Add("@Notes", SqlDbType.VarChar).Value = objRow[2].ToString();
                            var code = objRow[3].ToString();

                            if (!string.IsNullOrEmpty(code))
                            {
                                cmd.Parameters.Add("@CodeId", SqlDbType.Int).Value = Convert.ToInt32(code);
                            }
                            else
                            {
                                cmd.Parameters.Add("@CodeId", SqlDbType.Int).Value = DBNull.Value;
                            }

                            cmd.ExecuteScalar();

                        }

                    }
                    sqlCount++;
                    Logger.Log.Info($"{DateTime.Now},  Record with ID {objRow[0]} is imported");
                   

                }
                catch(Exception ex)
                {
                    Logger.Log.Error($"{DateTime.Now}, Error Record  is not imported {ex.Message}");
                }
               
               
            }
            if (sqlCount == csvCount)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public void ClearTable()
        {
            var _conn = new SqlConnection(ConnectionString);
            
                SqlCommand cmd = new SqlCommand("Delete  From InputData_table ", _conn);


                _conn.Open();
                cmd.ExecuteNonQuery();
            _conn.Close();
        }
       

    }
}

using ConsoleImportDBToCSV.ExtendedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImportDBToCSV
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input command:");
            string filename = Console.ReadLine();
            if(filename.Contains("Impexpdata -import"))
            {
                filename = filename.Remove(0, 18).Trim();
                var dal = new DAL();
                var dt=dal.GetData();
                var result = dal.CreateCSV(dt, filename);
                if(result)
                {
                    Console.WriteLine("Import finished:");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Import Error:");
                    Console.ReadLine();
                }
            }
            else if(filename.Contains("Impexpdata -export"))
            {
                filename = filename.Remove(0, 18).Trim();
                var dal = new DAL();
                var result = dal.LoadDataToSql(filename);
                
                if (result)
                {
                    Console.WriteLine("Export finished:");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Export Error:");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Command Error:");
              
            }
        }
    }
}

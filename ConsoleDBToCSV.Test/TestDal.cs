using ConsoleImportDBToCSV.ExtendedClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBToCSV.Test
{
 
    public  class TestDal
    {
        [Test]
        public void TestExportToCsv()
        {
            var dal = new DAL();
           
            var dt = dal.GetData();
            var csv = dal.CreateCSV(dt,"Export");

            Assert.IsTrue(csv);
        }
        [Test]
        public void TestImportToSql()
        {
            var dal = new DAL();

           
            var result= dal.LoadDataToSql("Import");

            Assert.IsTrue(result);
        }

    }
}

using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleImportDBToCSV.ExtendedClasses
{
   public class Logger
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);



        public static ILog Log
        {
            get { return log; }
        }

        public static void InitLogger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}

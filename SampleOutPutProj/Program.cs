using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StationaryDAL;
using StationaryServices;

namespace SampleOutPutProj
{
    class Program
    {
        //private static readonly log4net.ILog log =
        //    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            SQLDataProvider prov = new SQLDataProvider("Some Connection String");
      
             StationaryLogger.Info("Application is working");


            Console.ReadLine();
        }
    }
}

using StationaryServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryDAL
{
    public class SQLDataProvider
    {
        private string ConnectionString { get; set; }

        public SQLDataProvider(string connString)
        {
            ConnectionString = connString;
             //logger = new StationaryLogger();
             StationaryLogger.Info("Connection String: " + connString);
        }


        public int GetSample()
        {
            int rtnVal=0;
            SqlConnection conn = new SqlConnection(ConnectionString);

            return rtnVal;
        }



    }
}

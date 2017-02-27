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
        }


        public int GetSample()
        {
            int rtnVal=0;
            SqlConnection conn = new SqlConnection(ConnectionString);

            return rtnVal;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StationaryDAL;
using StationaryServices;

namespace StationaryWeb
{
    public partial class StationaryLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string m_connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SQLDataProvider prov = new SQLDataProvider("Some Connection String");
            StationaryLogger.Info("Application is working");

        }
    }
}
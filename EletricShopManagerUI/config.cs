using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EletricShopManagerUI
{
    public class config
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GQOJ4E2\\SIRIUS;Initial Catalog=dassBElectricals;Integrated Security=True");
        public config()
        {
            
        }

        public SqlConnection ActiveCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
    }
}

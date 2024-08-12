using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   //Main
using System.Configuration;   //Main
using System.Windows.Forms;

namespace MTPRAC_.DAL
{
    public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();

            connDB.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            connDB.Open();

            return connDB;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapMeeDesktop.Databases
{
    public class UserDatabase
    {
        public static string myConnection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            // 1. Connecting database
            SqlConnection connection = new SqlConnection(myConnection);
            DataTable dt = new DataTable();

            try
            {
                // 2. Write SQL query
                string sql = "SELECT * FROM table_user";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}

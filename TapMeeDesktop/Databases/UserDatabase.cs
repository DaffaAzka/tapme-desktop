using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapMeeDesktop.MVC.Models;

namespace TapMeeDesktop.Databases
{
    public class UserDatabase
    {
        public static string myConnection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public List<User> Select()
        {
            List<User> users = new List<User>();
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
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    User user = new User();
                    user.Id = int.Parse(dr["Id"].ToString());
                    user.Username = dr["Username"].ToString();
                    user.Email = dr["Email"].ToString();
                    user.Password = dr["Password"].ToString();
                    user.Point = int.Parse(dr["Point"].ToString());
                    users.Add(user);
                }
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }
            return users;
        }
    }
}

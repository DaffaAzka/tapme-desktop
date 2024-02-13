using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapMeeDesktop.Databases;
using TapMeeDesktop.MVC.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TapMeeDesktop.MVC.Controllers
{
    public class SignUp : InterfaceSignUp
    {
        SqlConnection connection = new SqlConnection(UserDatabase.myConnection);
        UserDatabase userDatabase = new UserDatabase();


        public bool emailExist(string s)
        {
            List<User> temp = userDatabase.Select();


            foreach (var item in temp)
            {
                if (item.Email.ToLower() == s.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool register(User model)
        {
            bool s = false;
            try
            {
                string sql = "INSERT into table_user (Username, Email, Password, Point) VALUES (@Username, @Email, @Password, @Point)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", model.Username);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@Password", model.Password);
                command.Parameters.AddWithValue("@Point", model.Point);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                Console.WriteLine(rows);
                s = (rows > 0);
            }
            catch (SqlException ex)
            { 
                MessageBox.Show("" + ex);
            }
            finally
            {
                connection.Close();
            }
            return s;
        }

        public bool usernameExist(string s)
        {
            List<User> temp = userDatabase.Select();


            foreach (var item in temp)
            {
                if (item.Username.ToLower() == s.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}

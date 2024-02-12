using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapMeeDesktop.Databases;

namespace TapMeeDesktop.MVC.Controllers
{
    public class SignIn : InterfaceSignIn
    {
        SqlConnection connection = new SqlConnection(UserDatabase.myConnection);
        List<string> temp = new List<string>();
        private void getEmail()
        {
            temp = new List<string>();
            try
            {
                string sql = "SELECT Email FROM table_user";
                SqlCommand comm = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = comm.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    temp.Add(reader.GetValue(i).ToString());
                    i++;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void getPassword()
        {
            temp = new List<string>();
            try
            {
                string sql = "SELECT Password FROM table_user";
                SqlCommand comm = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = comm.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    temp.Add(reader.GetValue(i).ToString());
                    i++;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool login(string email, string password)
        {
            bool b = false;
            getEmail();
            foreach (var emails in temp)
            {
                if(emails.Equals(email))
                {
                    getPassword();
                    foreach (var passwords in temp)
                    {
                        if (passwords.Equals(password))
                        {
                            b = true;
                        }
                    }
                }
            }
            return b;
        }
    }
}

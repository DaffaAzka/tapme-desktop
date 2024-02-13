using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapMeeDesktop.Data;
using TapMeeDesktop.Databases;
using TapMeeDesktop.MVC.Models;

namespace TapMeeDesktop.MVC.Controllers
{
    public class SignIn : InterfaceSignIn
    {
        SqlConnection connection = new SqlConnection(UserDatabase.myConnection);
        UserDatabase userDatabase = new UserDatabase();
        
        
        public bool login(string email, string password)
        {
            List<User> temp = userDatabase.Select();
            bool b = false;
            foreach (var users in temp)
            {
                if (users.Email.Equals(email))
                {
                    if (users.Password.Equals(password))
                    {
                        UserData.Id = users.Id;
                        UserData.Username = users.Username;
                        UserData.Email = users.Email;
                        UserData.Point = users.Point;
                        b = true;
                    }
                }
            }
            return b;
        }
    }
}

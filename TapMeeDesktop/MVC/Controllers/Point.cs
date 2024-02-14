using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapMeeDesktop.Data;
using TapMeeDesktop.Databases;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TapMeeDesktop.MVC.Controllers
{
    public class Point : InterfacePoint
    {
        public bool setPoint()
        {
            SqlConnection connection = new SqlConnection(UserDatabase.myConnection);
            bool s = false;
            try
            {
                string sql = "UPDATE table_user SET Point=@Point WHERE Id=@Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Point", UserData.Point);
                command.Parameters.AddWithValue("@Id", UserData.Id);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    s = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                connection.Close();
            }
            return s;
        }
    }
}

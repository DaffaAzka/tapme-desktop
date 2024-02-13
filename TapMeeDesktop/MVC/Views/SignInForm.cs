using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapMeeDesktop.Data;
using TapMeeDesktop.MVC.Controllers;

namespace TapMeeDesktop.MVC.Views
{
    public partial class SignInForm : Form
    {
        InterfaceSignIn signIn = new SignIn();
        private string myConnection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            bool success = signIn.login(emailBox.Text, passwordBox.Text);
            if (success)
            {
                
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Close();
                

                // MessageBox.Show($"{UserData.Id} {UserData.Username} {UserData.Email} {UserData.Point} ");

            }
            else
            {
                MessageBox.Show("Failed to login, email or password is invalid!");
            }

        }
    }
}

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
using TapMeeDesktop.Databases;
using TapMeeDesktop.MVC.Controllers;
using TapMeeDesktop.MVC.Models;

namespace TapMeeDesktop.MVC.Views
{
    public partial class SignUpForm : Form
    {
        User userModel = new User();
        InterfaceSignUp signUp = new SignUp();
        private string myConnection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        UserDatabase database = new UserDatabase();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            userModel.Username = usernameBox.Text;
            userModel.Email = emailBox.Text;
            userModel.Password = passwordBox.Text;
            userModel.Point = 0;

            if (signUp.emailExist(userModel.Email) || signUp.usernameExist(userModel.Username))
            {
                 MessageBox.Show("Email or Username already exists!");            
            }
            else
            {
                bool success = signUp.register(userModel);
                if (success)
                {
                    SignInForm signIn = new SignInForm();
                    signIn.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register, please try again later...");
                }
            }

        }
    }
}

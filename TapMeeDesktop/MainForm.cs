using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapMeeDesktop.MVC.Views;

namespace TapMeeDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            SignUpForm upForm = new SignUpForm();
            upForm.Show();
            this.Hide();
        }

        private void inButton_Click(object sender, EventArgs e)
        {
            SignInForm inForm = new SignInForm();
            inForm.Show();
            this.Hide();
        }
    }
}

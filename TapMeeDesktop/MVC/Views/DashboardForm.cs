using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapMeeDesktop.Data;
using TapMeeDesktop.MVC.Controllers;
using Point = TapMeeDesktop.MVC.Controllers.Point;

namespace TapMeeDesktop.MVC.Views
{
    public partial class DashboardForm : Form
    {
        InterfacePoint point = new Point();
        int pointTemp = 0;
        public DashboardForm()
        {
            InitializeComponent();
            pointTextLabel.Text = $"{UserData.Id} | {UserData.Username}";
            pointLabel.Text = UserData.Point.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pointTemp = pointTemp + 1;
            if (pointTemp ==  10)
            {
                UserData.Point = UserData.Point + pointTemp;
                point.setPoint();
                pointTemp = 0;
            }
            pointLabel.Text = (UserData.Point + pointTemp).ToString();

        }
    }
}

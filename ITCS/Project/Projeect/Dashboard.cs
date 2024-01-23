using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SergantLb_Click(object sender, EventArgs e)
        {
            Sergents obj = new Sergents();
            obj.Show();
            this.Hide();
        }

        private void DashLb_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void DriverLb_Click(object sender, EventArgs e)
        {
            Driver obj = new Driver();
            obj.Show();
            this.Hide();
        }

        private void UserLb_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void ProfileLb_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
            this.Hide();
        }
    }
}

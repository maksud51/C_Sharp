using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCS
{
    public partial class sergantDashboard : Form
    {
        string sergentUserName = login.SergentUserName;
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        public sergantDashboard()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(cs);
            string qurey_Name = " Select Name from Sergent_Info  where UserName=@UserName";
            /*string qurey_img = " Select Image from Sergent_Info  where UserName=@UserName";*/
            SqlCommand cmd_Name = new SqlCommand(qurey_Name, con);
            /*SqlCommand cmd_img = new SqlCommand(qurey_img, con);*/
            cmd_Name.Parameters.AddWithValue("@UserName", sergentUserName);
            /*cmd_img.Parameters.AddWithValue("@UserName", sergentUserName);*/
            con.Open();
            sergentName.Text = cmd_Name.ExecuteScalar().ToString();
            /*sergentImage.Image = GetPhoto((byte[])cmd_img.ExecuteScalar());*/
        }

        private void CheckRegistrationButton_Click(object sender, EventArgs e)
        {
            CheeckRegistrationForm obj = new CheeckRegistrationForm();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void AllotFine_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlloteFineForm allote = new AlloteFineForm();
            allote.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void SpeedBreak_Click(object sender, EventArgs e)
        {
            SpeedBreakList obj = new SpeedBreakList();
            obj.Show();
            this.Hide();
        }

        private void sergentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

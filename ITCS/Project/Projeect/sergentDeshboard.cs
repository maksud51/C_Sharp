using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Projeect
{
    public partial class sergentDeshboard : Form
    {
        string sergentUserName = LoginForm.SergentUserName;
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        public sergentDeshboard()
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

/*        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }*/


        private void CheckRegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheeckRegistrationForm check_reg = new CheeckRegistrationForm();
            check_reg.Show();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlloteFineForm allote = new AlloteFineForm();
            allote.Show();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpeedBreakList allote = new SpeedBreakList();
            allote.Show();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProfile_sergent_  update = new UpdateProfile_sergent_();
            update.Show();
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logout = new LoginForm();
            logout.Show();
        }
    }
}

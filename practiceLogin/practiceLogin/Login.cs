using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOMDTM3;Initial Catalog=Reg;Integrated Security=True");
   

        private void LogInProfile_Click(object sender, EventArgs e)
        {

            if (nameLogin.Text.Trim() == "")
            {
                MessageBox.Show("Enter First Name");
                nameLogin.Focus();
                return;
            }

            if (nameLogin.Text.Length > 10)
            {
                MessageBox.Show("First Name is too much");

            }

            con.Open();
            string query = "Select Count(*) from Reg where name='" + nameLogin.Text + "' and Password='" + passTextBox1.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Profile f2 = new Profile();
                this.Hide();
                f2.Show();
            }
            //if (textBox_UN.Text == "admin" && textBox_PW.Text == "admin")
            //{
            //    StudentRegistration f2 = new StudentRegistration();
            //    this.Hide();
            //    f2.Show();
            //}
            else
            {
                MessageBox.Show("Wrong Credentials!!!\nTry again.");
            }
        }
    }
    }







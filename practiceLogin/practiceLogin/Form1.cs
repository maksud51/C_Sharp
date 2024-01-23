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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOMDTM3;Initial Catalog=Reg;Integrated Security=True");
        
 

        private void RegButton_Click(object sender, EventArgs e)
        {
               if(nameTextBox.Text.Trim()=="")
            {
                MessageBox.Show("Enter First Name");
                nameTextBox.Focus();
                return;
            }

               if(nameTextBox.Text.Length > 10)
            {
                MessageBox.Show("First Name is too much");

            }

            con.Open();
            string querry = "INSERT INTO Reg(name,pass)VALUES('" + nameTextBox.Text + "', '" + passTextBox.Text + "')";
            SqlCommand cmd = new SqlCommand(querry,con);
            int rowCount=cmd.ExecuteNonQuery();
            con.Close();
            if(rowCount > 0)
            {
                MessageBox.Show("Regstratin Successfully");
            }

            else
            {
                MessageBox.Show("Regstration Faild,Please try Again");

            }

/*           string name = nameTextBox.Text;
            string pass = passTextBox.Text;*/
            nameTextBox.Clear();
            passTextBox.Clear();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();



        }
    }
}

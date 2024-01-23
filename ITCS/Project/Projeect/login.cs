using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace ITCS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public static string SergentUserName;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }

        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Validation


            Regex userNemeExp = new Regex(@"^[a-zA-Z][\w\s-]+");
            bool validUserName = userNemeExp.IsMatch(userName.Text);


            if (userName.Text.Trim() == "")

            {
                MessageBox.Show("Empty User Name box.\n Please Enter User Name.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                userName.Focus();
                return;
            }

            else if (userName.Text.Length > 15 || userName.Text.Length < 4)
            {
                MessageBox.Show("User Name is too much long or Short.\n Please Re-Enter User Name. \n Your User Name Must be contain 4 to 15 Latter", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                userName.Focus();
                return;

            }

            else if (validUserName == false)
            {
                MessageBox.Show("Fast Later Must be an alphabate!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                userName.Focus();
                return;
            }


            else
            {
                password.Focus();
            }

            //Password

            if (password.Text.Trim() == "")

            {
                MessageBox.Show("Empty password fild.\n Please Enter Password.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                password.Focus();
                return;
            }

            else if (password.Text.Length > 50)
            {
                MessageBox.Show("Invalid Password. \n Try Again!! ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                password.Focus();
                return;
            }


            else
            {
                loginBtn.Focus();

            }
            //Login Control

            string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = " select * from UserLogin where UserName=@UserName and Password=@Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", userName.Text);
            cmd.Parameters.AddWithValue("@Password", password.Text);
            con.Open();
            SqlDataReader Type = cmd.ExecuteReader();

            if (Type.HasRows == true)
            {
                Type.Read();
                if (Type[3].ToString() == "Sergent")
                {
                    if (Type[4].ToString() == "Active")
                    {
                        SergentUserName = userName.Text;
                        this.Hide();
                        sergantDashboard Login = new sergantDashboard();
                        Login.Show();
                    }

                    else
                    {
                        this.Hide();
                        login LoginPending = new login();
                        LoginPending.Show();
                    }

                }
                if (Type[3].ToString() == "Driver")
                {
                    if (Type[4].ToString() == "Active")
                    {
                        SergentUserName = userName.Text;
                        this.Hide();
                        Driver Login = new Driver();
                        Login.Show();
                    }

                    else
                    {
                        this.Hide();
                        login LoginPending = new login();
                        LoginPending.Show();
                    }

                }
                if (Type[3].ToString() == "Admin")
                {
                    if (Type[4].ToString() == "Active")
                    {
                        SergentUserName = userName.Text;
                        this.Hide();
                       Dashboard Login = new Dashboard();
                        Login.Show();
                    }

                    else
                    {
                        this.Hide();
                        login LoginPending = new login();
                        LoginPending.Show();
                    }

                }

            }
            else
            {
                MessageBox.Show("Invalid Password or User Name. \n Try Again!! ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                password.Focus();
                return;
            }




        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }

            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm SignUp = new RegistrationForm();
            SignUp.Show();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ForgotPasswordForm f_password = new ForgotPasswordForm();
            //f_password.Show();
        }
    }
}

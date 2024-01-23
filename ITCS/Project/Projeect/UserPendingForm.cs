using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeect
{
    public partial class UserPendingForm : Form
    {
        public UserPendingForm()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        private void send_Click(object sender, EventArgs e)
        {

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
                message.Focus();
            }


            if (message.Text.Trim() == "")
            {

                MessageBox.Show("Message Box Empty!! Please Enter Your Message", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                message.Focus();
                return;

            }
            



                
                SqlConnection con = new SqlConnection(cs);
                string query = " select * from UserLogin where UserName=@UserName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", userName.Text);
                con.Open();
                SqlDataReader Type = cmd.ExecuteReader();
                


            if (Type.HasRows == true)
                {
                    Type.Read();

                    if (Type[4].ToString() == "Pending")
                    {
                    con.Close();

                        string querry_msg = "INSERT INTO UserActivation(UserName, Message)VALUES ('" + userName.Text + "', '" + message.Text + "')";
                        SqlCommand cmd_log = new SqlCommand(querry_msg, con);
                        con.Open();
                        int a = cmd_log.ExecuteNonQuery();
                        if(a > 0)
                        {
                            MessageBox.Show("You will get Response from Admin Penal within 24 hours. ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Your Message Can't Send", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }

                        con.Close();
                    }

                    else
                    {
                        MessageBox.Show("Your Account Already Activatet. ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                  
            }
              

                else
                {
                    MessageBox.Show("You are not Registerd \n Please Create your Account", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Hide();
                    RegistrationForm reg = new RegistrationForm();
                    this.Show();
                }


            

            

        }
    }
}

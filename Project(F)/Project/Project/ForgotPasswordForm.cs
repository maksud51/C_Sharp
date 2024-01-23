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

namespace Project
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        int OTP;

        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        private void changePassword_Click(object sender, EventArgs e)
        {
            //Number

            Regex phonenumber = new Regex("\\d{3}-\\d{8}");
            bool validNumber = phonenumber.IsMatch(number.Text);

            if (number.Text.Trim() == "")
            {
                MessageBox.Show("Empty Number box.\n Please Enter Your Number.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                number.Focus();
                return;

            }


            else if (validNumber == false)
            {
                MessageBox.Show("In Valid Phone Number. \n Please Enter Valid Number.\n Formation:- 0XX-XXXXXXXX", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                number.Focus();
                return;
            }

            else
            {
                otp.Focus();
            }


            //OTP Number
            bool isDigit = otp.Text.All(Char.IsDigit);

            if (otp.Text.Trim() == "")
            {
                MessageBox.Show("Empty OTP box.\n Please Enter Your OTP.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                otp.Focus();
                return;
            }



            else if (isDigit == false)
            {
                MessageBox.Show("OTP Only Numeric code \n Please Re-Enter Right OTP", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                otp.Focus();
                return;
            }

            else if (otp.Text != OTP.ToString())
            {
                MessageBox.Show("Wrong OTP!! \n Please Enter Right OTP", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                otp.Focus();
                return;
            }

            else
            {
                newPassword.Focus();
            }

            if (newPassword.Text.Trim() == "")
            {
                MessageBox.Show("Empty New Password box.\n Please Enter Your New Password.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                newPassword.Focus();
                return;
            }

            else
            {
                confirmPassword.Focus();
            }

            if (confirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Empty Confirm Password box.\n Please Enter Confirm Password.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                confirmPassword.Focus();
                return;
            }

            else if (newPassword.Text != confirmPassword.Text)
            {
                MessageBox.Show("Confirm Password is not match with New Password.\n Please Re-Enter Right confirm Password", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                confirmPassword.Focus();
                return;
            }

            else
            {
                changePassword.Focus();
            }


            SqlConnection con = new SqlConnection(cs);
            String qurey_userLog = " Update  UserLogin set Password=@Password  where Number=@Number";
            SqlCommand cmd_log = new SqlCommand(qurey_userLog, con);
            cmd_log.Parameters.AddWithValue("@Number", number.Text);
            cmd_log.Parameters.AddWithValue("@Password", confirmPassword.Text);
            con.Open();
            int a = cmd_log.ExecuteNonQuery();

            if (a > 0)
            {


                /*               String qurey_DriverInfo = " Update  Driver_Info set Password=@Password  where Number=@Number";
                                String qurey_UserInfo = " Update  User_Info set Password=@Password  where Number=@Number";*/
                String qurey_SergentInfo = " Update  Sergent_Info set Password=@Password  where Number=@Number";
                /*                SqlCommand cmd_Driver = new SqlCommand(qurey_DriverInfo, con);
                                SqlCommand cmd_User = new SqlCommand(qurey_UserInfo, con);*/
                SqlCommand cmd_Sergent = new SqlCommand(qurey_SergentInfo, con);
                /*                cmd_Driver.Parameters.AddWithValue("@Number", number.Text);
                                cmd_Driver.Parameters.AddWithValue("@Password", confirmPassword.Text);
                                cmd_User.Parameters.AddWithValue("@Number", number.Text);
                                cmd_User.Parameters.AddWithValue("@Password", confirmPassword.Text);*/
                cmd_Sergent.Parameters.AddWithValue("@Number", number.Text);
                cmd_Sergent.Parameters.AddWithValue("@Password", confirmPassword.Text);
                /*                cmd_Driver.ExecuteNonQuery();
                                cmd_User.ExecuteNonQuery();*/
                cmd_Sergent.ExecuteNonQuery();
                MessageBox.Show("Password Change Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                number.Clear();
                otp.Clear();
                newPassword.Clear();
                confirmPassword.Clear();
            }

            else
            {
                MessageBox.Show("Password Change!!! \n Try Again", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }

        }

        private void getOTP_Click(object sender, EventArgs e)
        {
            if (number.Text.Trim() !="")
            {
                SqlConnection con = new SqlConnection(cs);
                String qurey_number = " Select number from UserLogin where Number=@Number";
                SqlCommand cmd = new SqlCommand(qurey_number, con);
                cmd.Parameters.AddWithValue("@Number", number.Text);
                con.Open();
                if (cmd.ExecuteScalar() != null)
                {
                    Random random = new System.Random();
                    int value = random.Next(1111, 9999);
                    OTP = value;
                    MessageBox.Show("OTPS IS: " + OTP, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    otp.Text = OTP.ToString();
                }
                else
                {

                    MessageBox.Show("Number Dosn't Exist. \n Please Enter Valid Number", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    number.Focus();
                    number.Clear();
                    return;

                }


            }

            else
            {
                MessageBox.Show("Empty Number Box.\n Please Enter Your Valid Number", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                number.Focus();

                return;
            }

        }
    }
}

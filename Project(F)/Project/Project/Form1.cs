using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOMDTM3;Initial Catalog=ITCS;Integrated Security=True");


        private void signUp_Click(object sender, EventArgs e)
        {
            // Text Fild Validation

            //Name

            Regex nemeExp = new Regex(@"[a-zA-Z]");
            bool validName = nemeExp.IsMatch(name.Text);

            if (name.Text.Trim()=="")

                {
                    MessageBox.Show(" Empty Name box.\n Please Enter Your Name.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    name.Focus();
                    return;
                }

            else if (name.Text.Length > 20 || name.Text.Length < 3)
                {
                    MessageBox.Show("Name is too much long or short. \n Please Enter Valid name. \n Your name Must be contain 3 to 20 Latter", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    name.Focus();
                    return;
                }


            else if (validName == false)
            {
                MessageBox.Show("Invalid Name. \n Please Enter Valid name. \n You Must use only latter", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                name.Focus();
                return;
            }

            else
            {
                userName.Focus();
            }

            //User Name
            
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
                dob.Focus();
            }


            //Uniq User Name validation

            try
            {
                string query = "Select Count(*) from Sergent_Info where UserName='" + userName.Text + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("User Name Already Existence. \n Please Enter Another User Name ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    userName.Focus();
                    return;
                }

                else
                {
                    dob.Focus();
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }



            //Date of Birth

            string dateOfBirth = dob.Value.ToString("dddd, dd MMMM yyyy");
            string toDate = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            if (dob.Value.ToString() == "")

            {
                MessageBox.Show("Empty Date of Birth Fild.\n  Please select date!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dob.Focus();
                return;
            }

            else if(dateOfBirth == toDate)
            {
                MessageBox.Show("Please Pick Your Date Of Birth", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dob.Focus();
                return;
            }
           else
            {
                gender.Focus();
            }

            //Gender

            if (gender.SelectedIndex == -1)

            {
                MessageBox.Show("Empty Gender box or Invalid Gender.\n Please Select Your Gender.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                userName.Focus();
                return;
            }

            else
            {
                pio.Focus();
            }

            //Postal Code

            bool isDigit = pio.Text.All(Char.IsDigit);

            if (pio.Text.Trim() == "")

            {
                MessageBox.Show("Empty Name box.\n Please Enter Your Postal Code.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                pio.Focus();
                return;
            }


            else if (pio.Text.Length > 6 || pio.Text.Length < 3)
            {
                MessageBox.Show("Postal Code too much Long or short. \n Please Re-Enter Valid Postal Code. postal code Must be contain 3 to 5 number");
                pio.Focus();
                return;

            }

            else if (isDigit == false)

            {
                MessageBox.Show("Postal code Only Numeric code \n Please Re-Enter Right postal code");
                pio.Focus();
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

            else
            {
                number.Focus();
            }

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
                email.Focus();
            }



            try
            {
                con.Open();
                string query1 = " select * from Sergent_Info where Number=@Number";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@Number", number.Text);


                SqlDataReader Type = cmd1.ExecuteReader();


                if (Type.HasRows == true)
                {
                    MessageBox.Show("Number Already Existence. \n Please Enter Another Number ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    number.Focus();
                    return;
                }

                else
                {
                    email.Focus();
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }




            //Email

            Regex emailaddress = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[^@\s]+\.(com|net|org|gov)$");

            bool validemail = emailaddress.IsMatch(email.Text);

            if (email.Text.Trim() == "")
            {
                MessageBox.Show("Empty Email box.\n Please Enter Your Email.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                email.Focus();
                return;

            }


            else if(validemail == false)
            {
                MessageBox.Show("In Valid Email Address. \n Please Enter Valid Email Address.\n Formation:- aa@bbbb.com/aa@bbbb.net/aa@bbbb.org/aa@bbbb.gov", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                email.Focus();
                return;
            }

            else
            {
                userPicture.Focus();
            }


            try
            {
                con.Open();
                string query2 = " select * from Sergent_Info where Email=@Email";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@Email", email.Text);

                SqlDataReader Type1 = cmd2.ExecuteReader();


                if (Type1.HasRows == true)
                {
                    MessageBox.Show("Email Address Already Existence. \n Please Enter Another Email ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    email.Focus();
                    return;
                }

                else
                {
                    userPicture.Focus();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }



            //Image

            if (userPicture.Image == null)
            {
                MessageBox.Show("Please Browse your Image.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                userPicture.Focus();
                return;
            }

            else
            {
                signUp.Focus();
            }

            //Insart Information in User Information Table
            con.Open();
            string querry = "INSERT INTO Sergent_Info(Name,UserName,Dob,Gender,PostalCode,Password,Number,Email,Image)VALUES('" + name.Text + "', '" + userName.Text + "', '" + dob.Value + "', '" + gender.Text + "', '" + pio.Text + "', '" + password.Text + "', '" + number.Text + "', '" + email.Text + "', '" + userPicture.Image + "')";

            SqlCommand cmd = new SqlCommand(querry, con);
            int rowCount = cmd.ExecuteNonQuery();
            con.Close();

            if (rowCount > 0)
            {
                MessageBox.Show("Regstratin Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Regstration Faild,Please try Again", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }







            //Clear Fild

            name.Clear();
            userName.Clear();
            dob.ResetText();
            gender.ResetText();
            pio.Clear();
            password.Clear();
            number.Clear();
            email.Clear();
            userPicture.Image = null;


        }
        //Image Browse Control
        private void userPictureButton_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                /*open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";*/

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imageLocation = dialog.FileName;
                    userPicture.ImageLocation = imageLocation;
                   /* Bitmap objBitmap = new Bitmap(userPicture.Image, new Size(50, 50));*/

                }
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        //Show Password control
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

        private void lkoginHere_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Show();
        }
    }
}

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

namespace Projeect
{
    public partial class AlloteFineForm : Form
    {
        public AlloteFineForm()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public static string SergentUserName = LoginForm.SergentUserName;
        public static string SergentName;
        public static string Status = "Unknown";

        private void alloteButton_Click(object sender, EventArgs e)
        {

            Regex userNemeExp = new Regex(@"^[a-zA-Z][\w\s-]+");
            bool validUserName = userNemeExp.IsMatch(userName.Text);

            if (userName.Text.Trim() == "")

            {
                MessageBox.Show("Empty User Name box.\n Please Enter User Name.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();
                return;
            }

            else if (userName.Text.Length > 15 || userName.Text.Length < 4)
            {
                MessageBox.Show("User Name is too much long or Short.\n Please Re-Enter User Name. \n Your User Name Must be contain 4 to 15 Latter", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();
                return;

            }

            else if (validUserName == false)
            {
                MessageBox.Show("Fast Later Must be an alphabate!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();
                return;
            }

            else
            {
                caseReason.Focus();
            }

            //User Existance

            SqlConnection con = new SqlConnection(cs);
            try
            {
                string query = "Select Count(*) from UserLogin where UserName='" + userName.Text + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows[0][0].ToString() != "1")
                {
                    MessageBox.Show("User Can't Existence. \n Please Enter Valid User Name ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    userName.Focus();
                    return;
                }

                else
                {
                    caseReason.Focus();
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }




            Regex nemeExp = new Regex(@"[a-zA-Z]");
            bool validReason = nemeExp.IsMatch(caseReason.Text);

            if (caseReason.Text.Trim() == "")
            {
                MessageBox.Show("Empty Case Reason Box.\n Please Enter Case Reason.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                caseReason.Focus();
                return;
            }

            else if (validReason == false)
            {
                MessageBox.Show("Case Reason can't exist numeric number .\n Please Enter Valid Case Reason by using Only Latter.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                caseReason.Focus();
                return;
            }

            else
            {
                amount.Focus();
            }


            bool isDigit = amount.Text.All(Char.IsDigit);

            if (amount.Text.Trim() == "")
            {
                MessageBox.Show("Empty Amount Box.\n Please Enter Amount.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amount.Focus();
                return;
            }


            else if (isDigit == false)
            {
                MessageBox.Show("Amount Only Numeric Number \n Please Re-Enter Amount", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amount.Focus();
                return;
            }

            else if (int.Parse(amount.Text) < 100)
            {
                MessageBox.Show("Amount Must be larger then 99Tk \n Please Re-Enter Valid Amount", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amount.Focus();
                return;
            }

            else
            {
                signalPoint.Focus();
            }

            if (signalPoint.Text.Trim() == "")
            {
                MessageBox.Show("Empty Signal Point Box.\n Please Enter Signal Point.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                signalPoint.Focus();
                return;
            }

            else
            {
                Date.Focus();
            }

            if (Date.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Date.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                alloteButton.Focus();
                return;
            }


            //DataBase

            /*SqlConnection con = new SqlConnection(cs);*/
            string qurey1 = " Select * from Penalty_Table  where UserName=@UserName";
            SqlCommand cmd1 = new SqlCommand(qurey1, con);
            cmd1.Parameters.AddWithValue("@UserName", userName.Text);
            con.Open();

            if (cmd1.ExecuteScalar() != null)
            {
                MessageBox.Show("THIS USER IS ALREADY PENALIZED");


            }

            else
            {

                string query2 = "INSERT INTO Penalty_Table(UserName,CaseReason,PenaltyAmount,SignalPoint,Date)VALUES('" + userName.Text + "',  '" + caseReason.Text + "', '" + amount.Text + "', '" + signalPoint.Text + "', '" + Date.Value + "')";
                string qurey3 = "INSERT INTO History_Table values(@UserName,@CaseReason,@PenaltyAmount,@SignalPoint,@SergentName,@Date,@Status)";





                SqlCommand cmd = new SqlCommand(query2, con);
                SqlCommand cmd2 = new SqlCommand(qurey3, con);



                cmd2.Parameters.AddWithValue("@UserName", userName.Text);
                cmd2.Parameters.AddWithValue("@CaseReason", caseReason.Text);
                cmd2.Parameters.AddWithValue("@PenaltyAmount", amount.Text);
                cmd2.Parameters.AddWithValue("@SignalPoint", signalPoint.Text);
                Get_SergentName();
                cmd2.Parameters.AddWithValue("@SergentName", SergentName);
                cmd2.Parameters.AddWithValue("@Date", Date.Value);
                cmd2.Parameters.AddWithValue("@Status", Status);


                int a = cmd.ExecuteNonQuery();
                int b = cmd2.ExecuteNonQuery();


                if (a > 0 && b > 0)
                {

                    MessageBox.Show("DATA INSERTED", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("DATA INSERTION FAILED", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();


            }
        }

        //Sergent name by use Sergent Id
        public void Get_SergentName()
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string qurey_getSname = " Select Name from Sergent_Info  where UserName=@UserName";
            SqlCommand cmd_getSname = new SqlCommand(qurey_getSname, con);
            cmd_getSname.Parameters.AddWithValue("@UserName", SergentUserName);
            SqlDataReader Type = cmd_getSname.ExecuteReader();


            if (Type.HasRows == true)
            {
                Type.Read();
                SergentName = Type[0].ToString();




            }


        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            sergentDeshboard back = new sergentDeshboard();
            back.Show();
        }
    }
}

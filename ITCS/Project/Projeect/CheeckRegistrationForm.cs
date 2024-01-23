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

namespace ITCS
{
    public partial class CheeckRegistrationForm : Form
    {
        public CheeckRegistrationForm()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        private void checkButton_Click(object sender, EventArgs e)
        {
            Regex userNemeExp = new Regex(@"^[a-zA-Z][\w\s-]+");
            bool validUserName = userNemeExp.IsMatch(userName.Text);

            if (userName.Text.Trim() == "")
            {
                MessageBox.Show("Searching Box Empty. \n Please Enter Valid User Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();
                return;
            }


            else if (userName.Text.Length > 15 || userName.Text.Length < 4)
            {
                MessageBox.Show("User Name is too much long or Short.\n Please Re-Enter User Name. \n Your User Name Must be contain 4 to 15 Latter", "Faile", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                userName.Focus();
                return;

            }

            else if (validUserName == false)
            {
                MessageBox.Show("Fast Later Must be an alphabate!!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();
                return;
            }

            else
            {
                checkButton.Focus();
            }


            SqlConnection con = new SqlConnection(cs);
            string query = " select * from DriverTb1 where DriverName=@UserName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", userName.Text);
            con.Open();
            SqlDataReader Type = cmd.ExecuteReader();

            if (Type.HasRows == true)
            {
                Type.Read();
                BindGridView();
                userName.Clear();

            }

            else
            {

                MessageBox.Show("Un-Registered Driver!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                userName.Focus();
                return;

            }
            con.Close();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from DriverTb1 where DriverName = '" + userName.Text + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataShow.DataSource = data;
            //AUTOSIZE
            dataShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            sergantDashboard back = new sergantDashboard();
            back.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

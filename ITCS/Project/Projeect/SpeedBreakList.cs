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

namespace ITCS
{
    public partial class SpeedBreakList : Form
    {
        public SpeedBreakList()
        {
            InitializeComponent();
            BindGridView();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["sq"].ConnectionString;


        //Nassecry Variable
        static string CaseReason = "Speed Break";
        static string PenaltyAmount = "500";
        static string Status = "Unknown";

        public static string SergentUserName = login.SergentUserName;
        public static string SergentName;

        //Reset Button Text
        public void Reset()
        {
            userName.Clear();
            signal.Clear();
            date.ResetText();


        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query_dataShow = "select * from SpeedBreak_Table";
            SqlDataAdapter sda = new SqlDataAdapter(query_dataShow, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGrid.DataSource = data;
            //AUTOSIZE
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                userName.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                signal.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                date.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

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

        private void takeAction_Click(object sender, EventArgs e)
        {
            if (userName.Text.Trim() != "" && signal.Text.Trim() != "" && date.Value.ToString() != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string qurey_1 = " Select * from Penalty_Table  where UserName=@UserName";
                SqlCommand cmd_1 = new SqlCommand(qurey_1, con);
                cmd_1.Parameters.AddWithValue("@UserName", userName.Text);
                con.Open();

                if (cmd_1.ExecuteScalar() != null)
                {
                    MessageBox.Show("THIS USER IS ALREADY PENALIZED", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string qurey_2 = " Delete from  SpeedBreak_Table where UserName=@UserName";
                    string query_3 = "INSERT INTO Penalty_Table(UserName,CaseReason,PenaltyAmount,SignalPoint,Date)VALUES('" + userName.Text + "',  '" + CaseReason + "', '" + PenaltyAmount + "', '" + signal.Text + "', '" + date.Value + "')";
                    string qurey_4 = "INSERT INTO History_Table values(@UserName,@CaseReason,@PenaltyAmount,@SignalPoint,@SergentName,@Date,@Status)";


                    SqlCommand cmd_2 = new SqlCommand(qurey_2, con);
                    SqlCommand cmd_3 = new SqlCommand(query_3, con);
                    SqlCommand cmd_4 = new SqlCommand(qurey_4, con);


                    cmd_2.Parameters.AddWithValue("@UserName", userName.Text);


                    cmd_4.Parameters.AddWithValue("@UserName", userName.Text);
                    cmd_4.Parameters.AddWithValue("@CaseReason", CaseReason);
                    cmd_4.Parameters.AddWithValue("@PenaltyAmount", PenaltyAmount);
                    cmd_4.Parameters.AddWithValue("@SignalPoint", signal.Text);
                    Get_SergentName();
                    cmd_4.Parameters.AddWithValue("@SergentName", SergentName);
                    cmd_4.Parameters.AddWithValue("@Date", date.Value);
                    cmd_4.Parameters.AddWithValue("@Status", Status);

                    int a = cmd_2.ExecuteNonQuery();
                    int b = cmd_3.ExecuteNonQuery();
                    int c = cmd_4.ExecuteNonQuery();
                    /*                    int b = cmd_3.ExecuteNonQuery();
                                        int c = cmd_4.ExecuteNonQuery();*/



                    if (a > 0 && b > 0 && c > 0)
                    {

                        BindGridView();
                        Reset();
                        MessageBox.Show("ACTION TAKEN", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("SOMETHING IS WRONG", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("No User Is Select", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void signal_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

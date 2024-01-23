using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCS
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            DisplayDri();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SMONPC\MSSQLSERVER01;Initial Catalog=ITCS;Integrated Security=True");

        int key = 0;
        private void DisplayDri()
        {
            con.Open();
            string Query = "Select * from AdminTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdminDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private object SPhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void Clear()
        {
            AName.Text = "";
            ArPassword.Text = "";
            AGender.Text = "";
            AMobno.Text = "";
            pictureBox.Image = null;
            key = 0;
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            return Image.FromStream(ms);
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || AGender.Text == "" || AdateTimePicker.Text == "" || AMobno.Text == "" || APassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AdminTb1(AdminName,AdminGender,AdminDOB,AdminMobNo,AdminPassword,Pic)values(@AN,@AG,@ADT,@AMN,@APA,@Photo)", con);

                    cmd.Parameters.AddWithValue("@AN", AName.Text);
                    cmd.Parameters.AddWithValue("@AG", AGender.Text);
                    cmd.Parameters.AddWithValue("@ADT", AdateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AMN", AMobno.Text);
                    cmd.Parameters.AddWithValue("@APA", APassword.Text);
                    cmd.Parameters.AddWithValue("@Photo", SPhoto());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Added");
                    con.Close();
                    DisplayDri();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Admin");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from AdminTb1 where AdminID=@AKey", con);


                    cmd.Parameters.AddWithValue("@AKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Deleted");
                    con.Close();
                    DisplayDri();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || AGender.Text == "" || AdateTimePicker.Text == "" || AMobno.Text == "" || APassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update AdminTb1 set  AdminName =@AN ,AdminGender =@AG , AdminDOB =@ADT ,AdminMobNo =@AMN ,AdminPassword = @APA, Pic = @Photo where AdminID=@AKey ", con);

                    cmd.Parameters.AddWithValue("@AN", AName.Text);
                    cmd.Parameters.AddWithValue("@AG", AGender.Text);
                    cmd.Parameters.AddWithValue("@ADT", AdateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AMN", AMobno.Text);
                    cmd.Parameters.AddWithValue("@APA", APassword.Text);
                    cmd.Parameters.AddWithValue("@Photo", SPhoto());
                    cmd.Parameters.AddWithValue("@AKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Updated");
                    con.Close();
                    DisplayDri();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Photo";
            ofd.Filter = "Image file(*.png;*jpeg;*jpg;*bmp) | *.png;*jpeg;*jpg;*bmp";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AName.Text = AdminDGV.SelectedRows[0].Cells[1].Value.ToString();
            AGender.Text = AdminDGV.SelectedRows[0].Cells[2].Value.ToString();
            AdateTimePicker.Text = AdminDGV.SelectedRows[0].Cells[3].Value.ToString();
            AMobno.Text = AdminDGV.SelectedRows[0].Cells[4].Value.ToString();
            APassword.Text = AdminDGV.SelectedRows[0].Cells[5].Value.ToString();
            pictureBox.Image = GetPhoto((Byte[])AdminDGV.SelectedRows[0].Cells[6].Value);



            if (AName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AdminDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void AType_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void DriverLb_Click(object sender, EventArgs e)
        {
            Driver obj = new Driver();
            obj.Show();
            this.Hide();
        }

        private void SergantLb_Click(object sender, EventArgs e)
        {
            Sergents obj = new Sergents();
            obj.Show();
            this.Hide();
        }

        private void DashLb_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

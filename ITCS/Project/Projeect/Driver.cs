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
using System.IO;

namespace ITCS
{
    public partial class Driver : Form
    {
        static string Status = "Active";
        public Driver()
        {
            InitializeComponent();
            DisplayDri();
        }

        
        SqlConnection con = new SqlConnection(@"Data Source=SMONPC\MSSQLSERVER01;Initial Catalog=ITCS;Integrated Security=True");

        private void DisplayDri()
        {
            con.Open();
            string Query = "Select * from DriverTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DriverDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (name.Text == ""  || dob.Text == "" || gender.Text == "" || pio.Text == "" || password.Text == "" || number.Text == "" || email.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into DriverTb1(Name,UserName,Dob,Gender,PostalCode,Password,Number,Email,Image)values(@DN,@DUN,@DG,@DDT,@DPC,@DPA,@DMN,@DEM,@Photo)", con);
                    SqlCommand cmd1 = new SqlCommand("Insert into UserLogin(UserName,Password,Number)values(@DUN,@DPA,@DMN)", con);
                    cmd.Parameters.AddWithValue("@DN", name.Text);
                    cmd.Parameters.AddWithValue("@DUN", userName.Text);
                    cmd.Parameters.AddWithValue("@DDT", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", gender.Text);
                    cmd.Parameters.AddWithValue("@DPC", pio.Text);
                    cmd.Parameters.AddWithValue("@DPA", password.Text);
                    cmd.Parameters.AddWithValue("@DMN", number.Text);
                    cmd.Parameters.AddWithValue("@DEM", email.Text);
                    cmd.Parameters.AddWithValue("@Photo", SPhoto());
                    cmd1.Parameters.AddWithValue("@DUN", userName.Text);
                    cmd1.Parameters.AddWithValue("@DPA", password.Text);
                    cmd1.Parameters.AddWithValue("@DMN", number.Text);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Driver Added");
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

        private object SPhoto()
        {
            MemoryStream ms = new MemoryStream();
            userPicture.Image.Save(ms, userPicture.Image.RawFormat);
            return ms.GetBuffer();
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
                    SqlCommand cmd = new SqlCommand("Delete from DriverTb1 where UserName=@DKey", con);
                    SqlCommand cmd1 = new SqlCommand("Delete from UserLogin where UserName=@DKey", con);

                    cmd.Parameters.AddWithValue("@DKey", key);
                    cmd1.Parameters.AddWithValue("@DKey", key);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
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
            if (name.Text == "" || dob.Text == "" || gender.Text == "" || pio.Text == "" || password.Text == "" || number.Text == "" || email.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update DriverTb1 set Name = @DN,Dob = @DDT,Gender = @DG,PostalCode = @DPC,Password = @DPA,Number = @DMN,Email = @DEM,Image = @Photo where UserName=@AKey", con);
                    SqlCommand cmd1 = new SqlCommand("update UserLogin set Password = @DPA,Number = @DMN where UserName=@AKey", con);

                    cmd.Parameters.AddWithValue("@DN", name.Text);
                    cmd.Parameters.AddWithValue("@DUN", userName.Text);
                    cmd.Parameters.AddWithValue("@DDT", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", gender.Text);
                    cmd.Parameters.AddWithValue("@DPC", pio.Text);
                    cmd.Parameters.AddWithValue("@DPA", password.Text);
                    cmd.Parameters.AddWithValue("@DMN", number.Text);
                    cmd.Parameters.AddWithValue("@DEM", email.Text);
                    cmd.Parameters.AddWithValue("@Photo", SPhoto());
                    cmd1.Parameters.AddWithValue("@DPA", password.Text);
                    cmd1.Parameters.AddWithValue("@DMN", number.Text);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
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

        private void Clear()
        {
            name.Text = "";
            password.Text = "";
            gender.Text = "";
            number.Text = "";
            userPicture.Image = null;
            key = 0;
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void DriverDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = DriverDGV.SelectedRows[0].Cells[1].Value.ToString();
            userName.Text = DriverDGV.SelectedRows[0].Cells[2].Value.ToString();
            dob.Text = DriverDGV.SelectedRows[0].Cells[3].Value.ToString();
            gender.Text = DriverDGV.SelectedRows[0].Cells[4].Value.ToString();
            pio.Text = DriverDGV.SelectedRows[0].Cells[5].Value.ToString();
            password.Text = DriverDGV.SelectedRows[0].Cells[6].Value.ToString();
            number.Text = DriverDGV.SelectedRows[0].Cells[7].Value.ToString();
            email.Text = DriverDGV.SelectedRows[0].Cells[8].Value.ToString();
            userPicture.Image = GetPhoto((Byte[])DriverDGV.SelectedRows[0].Cells[9].Value);



            if (name.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DriverDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            return Image.FromStream(ms);
        }

        private void DashLb_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void SergantLb_Click(object sender, EventArgs e)
        {
            Sergents obj = new Sergents();
            obj.Show();
            this.Hide();
        }

        private void UserLb_Click(object sender, EventArgs e)
        {
           
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Photo";
            ofd.Filter = "Image file(*.png;*jpeg;*jpg;*bmp) | *.png;*jpeg;*jpg;*bmp";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                userPicture.Image = new Bitmap(ofd.FileName);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string qry = "Select * From DriverTb1 where sergantName Like '%" + SearchBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                con.Close();
                DriverDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBox_Text(object sender, EventArgs e)
        {
            
        }

        private void SearchBox_DText(object sender, EventArgs e)
        {
            string qry = "Select * From DriverTb1 where userName Like '%" + SearchBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DriverDGV.DataSource = dt;
        }

        private void B(object sender, EventArgs e)
        {

        }

        private void ProfileLB_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
            this.Hide();
        }


        }
    }
}

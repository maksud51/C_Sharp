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
using ITCS.Properties;
using YamlDotNet.Serialization;

namespace ITCS
{
    public partial class Sergents : Form
    {
        public Sergents()
        {
            InitializeComponent();
            DisplayRec();
        }

        static string Status = "Active";
        string key = "";
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=SMONPC\MSSQLSERVER01;Initial Catalog=ITCS;Integrated Security=True");

        private void DisplayRec()
        {
            con.Open();
            string Query = "Select * from SergantTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SergantDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || gender.Text == "" || dob.Text == "" || number.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    con.Open();
                    string querry = "INSERT INTO Sergent_Info(Name,UserName,Dob,Gender,PostalCode,Password,Number,Email,Image)VALUES('" + name.Text + "', '" + userName.Text + "', '" + dob.Value + "', '" + gender.Text + "', '" + pio.Text + "', '" + password.Text + "', '" + number.Text + "', '" + email.Text + "', '" + SPhoto() + "')";
                    string querry_1 = "INSERT INTO UserLogin(UserName,Password,Number,Type,Status)VALUES( '" + userName.Text + "',  '" + password.Text + "', '" + number.Text + "', '" + userType.SelectedItem + "', '" + Status + "' )";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    SqlCommand cmd_1 = new SqlCommand(querry_1, con);
                    int rowCount = cmd.ExecuteNonQuery();
                    int rowCount_1 = cmd_1.ExecuteNonQuery();
                    con.Close();
                    DisplayRec();
                    userPicture.Image = Resources.Notavailable;
                    Clear();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private byte[] SPhoto()
        {
            MemoryStream ms = new MemoryStream();
            userPicture.Image.Save(ms, userPicture.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (key == "")
            {
                MessageBox.Show("Select The Sergant");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from sergant_Info where userName=@SKey", con);

                    
                    cmd.Parameters.AddWithValue("@SKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sergant Deleted");
                    con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        
        private void SergantDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            name.Text = SergantDGV.SelectedRows[0].Cells[0].Value.ToString();
            gender.Text = SergantDGV.SelectedRows[0].Cells[3].Value.ToString();
            dob.Text = SergantDGV.SelectedRows[0].Cells[2].Value.ToString();
            number.Text = SergantDGV.SelectedRows[0].Cells[6].Value.ToString();
            password.Text = SergantDGV.SelectedRows[0].Cells[5].Value.ToString();
            userPicture.Image =  GetPhoto((Byte[])SergantDGV.SelectedRows[0].Cells[8].Value);

            if(name.Text == "")
            {
                key = "";
            }
            else
            {
                key = SergantDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            return Image.FromStream(ms);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || gender.Text == "" || dob.Text == "" || number.Text == "" || number.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Update  Sergent_Info(Name,Dob,PostaCode,Email,Number,Image)values(@Name,@Dob,@PostaCode,@Email,@Number,@Image)", con);



                    cmd.Parameters.AddWithValue("@Name", name.Text);
                    cmd.Parameters.AddWithValue("@Dob", dob.Text);
                    cmd.Parameters.AddWithValue("@PostaCode", pio.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Number", password.Text);
                    cmd.Parameters.AddWithValue("@Image", SPhoto());
                    //cmd.Parameters.AddWithValue("@SKey", key);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sergant Updated");
                    con.Close();
                    DisplayRec();
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
            gender.Text = "";
            userPicture.Image = null;
            key = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashLb_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void DriverLb_Click(object sender, EventArgs e)
        {
            Driver obj = new Driver();
            obj.Show();
            this.Hide();
        }

        private void UserLb_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        
        private void BrowseBtn_Click(object sender, EventArgs e)
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
                userPicture.Image = new Bitmap(ofd.FileName);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            
        }

       
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string qry = "Select * From sergant_Info where sergantName Like '%" + SearchBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                con.Close();
                SergantDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBox_Text(object sender, EventArgs e)
        {
            string qry = "Select * From sergant_Info where userName Like '%" + SearchBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SergantDGV.DataSource = dt;
        }

        private void ProfileLb_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
            this.Hide();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

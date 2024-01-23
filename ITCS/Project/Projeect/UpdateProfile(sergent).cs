using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace Projeect
{
    public partial class UpdateProfile_sergent_ : Form
    {
        public UpdateProfile_sergent_()
        {
            InitializeComponent();
            BindGridView();
        }

        static string sergentUserName = LoginForm.SergentUserName;
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        //Reset

        public void Reset()
        {

            name.Clear();
            dob.ResetText();
            pio.Clear();
            password.Clear();
            number.Clear();
            email.Clear();
            userPicture.Image = null;
        }



        private void updateButton_Click(object sender, EventArgs e)
        {


            if (name.Text == "" || dob.Text == "" || pio.Text == "" || password.Text == "" || email.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update  Sergent_Info(Name,Dob,PostaCode,Email,Number,Image)values(@Name,@Dob,@PostaCode,@Email,@Number,@Image)", con);

                    cmd.Parameters.AddWithValue("@Name", name.Text);
                    cmd.Parameters.AddWithValue("@Dob", dob.Text);
                    cmd.Parameters.AddWithValue("@PostaCode", pio.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Number", password.Text);
                    cmd.Parameters.AddWithValue("@Image", SPhoto());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Updated");
                    con.Close();
                    BindGridView();
                    Reset();
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





        //Image Browse
        private void userPictureButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
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



        //DataGrid Store All Value From Database
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string Query = "select * from Sergent_Info where UserName='" + sergentUserName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
            con.Close();




            /*            SqlConnection con = new SqlConnection(cs);
                        string query = "select * from Sergent_Info where UserName='" + sergentUserName + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        dataGrid.DataSource = data;
                        ///Image Column
                        DataGridViewImageColumn dgv = new DataGridViewImageColumn();
                        dgv = (DataGridViewImageColumn)dataGrid.Columns[8];
                        dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
                        //AUTOSIZE
                        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        //Image Height
                        dataGrid.RowTemplate.Height = 60;




                        ///Image Column
                        DataGridViewImageColumn dgv = new DataGridViewImageColumn();



                        dgv = (DataGridViewImageColumn)dataGrid.Columns[8];
                        dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
                        //AUTOSIZE
                        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        //Image Height
                        dataGrid.RowTemplate.Height = 60;

                        dataGrid.AllowUserToAddRows = false;
                        sda.Dispose();*/
        }

        /*        private Image GetPhoto(byte[] photo)
                {
                    MemoryStream ms = new MemoryStream(photo);
                    return Image.FromStream(ms);
                }
        */
        //DataGrid View data trasfer to User Text Box
      
/*        private void dataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                name.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                dob.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                pio.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                password.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                email.Text = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                number.Text = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                userPicture.Image = GetPhoto((byte[])dataGrid.Rows[e.RowIndex].Cells[8].Value);


            }
        }*/

        private Image GetPhoto(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            return Image.FromStream(ms);
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            userPicture.Image.Save(ms, userPicture.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            sergentDeshboard back = new sergentDeshboard();
            back.Show();
        }
        int key = 0;
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            name.Text = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
            dob.Text = dataGrid.SelectedRows[0].Cells[2].Value.ToString();
            pio.Text = dataGrid.SelectedRows[0].Cells[4].Value.ToString();
            password.Text = dataGrid.SelectedRows[0].Cells[5].Value.ToString();
            email.Text = dataGrid.SelectedRows[0].Cells[7].Value.ToString();
            number.Text = dataGrid.SelectedRows[0].Cells[6].Value.ToString();
            userPicture.Image = GetPhoto((Byte[])dataGrid.SelectedRows[0].Cells[8].Value);

            if (name.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}

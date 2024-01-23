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

namespace Projeect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BindGridView();
        }

        static string sergentUserName = LoginForm.SergentUserName;
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Sergent_Info where UserName='" + sergentUserName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            datagrid.DataSource = data;
            ///Image Column
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();



            dgv = (DataGridViewImageColumn)datagrid.Columns[8];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //AUTOSIZE
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Image Height
            datagrid.RowTemplate.Height = 60;

            datagrid.AllowUserToAddRows = false;
            sda.Dispose();
        }
    }
}

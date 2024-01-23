using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Control_Video_15_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                MessageBox.Show("chacked");
            }
            string value = dptComboBox.Text;
            MessageBox.Show(value);
        }

        private void dpt(object sender, EventArgs e)
        {
            /*           List<string> dptList = new List<string>();
                        dptList.Add("CSE");
                        dptList.Add("EEE");
                        dptList.Add("ENG");
                        dptList.Add("BAN");

                        dptComboBox.DataSource = dptList;*/

            /*           // or
                        dptComboBox.Items.Add("CSE");
                        dptComboBox.Items.Add("EEE");
                        dptComboBox.Items.Add("ENG");*/

            //or
            List<string> dptList = new List<string>();
            dptList.Add("CSE");
            dptList.Add("EEE");
            dptList.Add("ENG");
            dptList.Add("BAN");

            foreach (var data in dptList)
            {
                dptComboBox.Items.Add(data);
            }

        }
        
        private void logInButton_Click(object sender, EventArgs e)
        {



            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgcolor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if(comboBox1.SelectedItem.ToString() == "Driver")
            {
                panel1.Visible = true;
            }

            else if(comboBox1.SelectedItem.ToString() == "Sergent")
            {
                panel2.Visible = true;
            }


            /*            string result = ((ComboBox)sender).SelectedItem.ToString();
                        textBox1.Text = result;
                        string r = "driver";


                        if (result =r)
                        {

                        }*/

        }
    }
}

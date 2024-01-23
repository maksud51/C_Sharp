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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

        private void addButton_Click(object sender, EventArgs e)
        {
            string value = dptComboBox.Text;
            dptListBox.Items.Add(value);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HelloUI : Form
    {
        public HelloUI()
        {
            InitializeComponent();
        }



        private void ShowButton_Click(object sender, EventArgs e)
        {
            /* string name = firstNameTextBox.Text;
             MessageBox.Show("Hi " + name+ " Hellow World","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);*/

            if(firstNameTextBox.Text.Trim()=="")
            {
                MessageBox.Show("Enter First Name");
                firstNameTextBox.Focus();
                return;

            }


            if (firstNameTextBox.Text.Length > 10)
            {
                MessageBox.Show("First Name is too much long.You can use highest  9 charecter.");
                return;
            }


            if (middleNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Middle Name");
                middleNameTextBox.Focus();
                return;

            }


            if (middleNameTextBox.Text.Length > 10)
            {
                MessageBox.Show("Middle Name is too much long.You can use highest  9 charecter.");
                return;
            }

            if (lastNametextBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Last Name");
                lastNametextBox.Focus();
                return;

            }

            if (lastNametextBox.Text.Length > 10)
            {
                MessageBox.Show("Last Name is too much long.You can use highest  9 charecter.");
                return;
            }

            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lstName = lastNametextBox.Text;

            string fullName = firstName + " " + middleName + " " + lstName;
            fullNameTextBox.Text = fullName;
            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNametextBox.Clear();
        }
    }
}

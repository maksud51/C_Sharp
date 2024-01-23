using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class registrationUI : Form
    {
        public registrationUI()
        {
            InitializeComponent();
        }

        private void sergentSignUpButton_Click(object sender, EventArgs e)
        {
            //Form Validation

            if (SergentName.Text.Trim()=="")
            {
                MessageBox.Show("Empty Name box.\n Please Enter Your Name.");
                SergentName.Focus();
                return;
            }

            if (SergentName.Text.Length > 11)
            {
                MessageBox.Show("Name is too much long.Please Enter Shorter name.Maximum Length 11 Latter");
                return;
            }


            if (sergentUserName.Text.Trim() == "")
            {
                MessageBox.Show("Empty Name box.\n Please Enter Your Name.");
                sergentUserName.Focus();
                return;
            }

            if (sergentUserName.Text.Length > 10 )
            {
                MessageBox.Show("User Name is too much long. \n Please Enter Shorter User name.Maximum Length 10 Latter");
                return;

            }

            if (sergentDob.Text.Trim()=="")
            {
                MessageBox.Show("Empty Name box.\n Please Enter Your Date Of Birth.");
                sergentDob.Focus();
                return;
            }

            if (sergentGender.Text.Trim()=="")
            {
                MessageBox.Show("Empty Name box.\n Please Enter Your Gender.");
                sergentGender.Focus();
                return;
            }

            if (postalCode.Text.Trim()=="")
            {
                MessageBox.Show("Empty Name box.\n Please Enter Your Postal Code.");
                postalCode.Focus();
                return;
            }

            if (passoword.Text.Trim()=="")
            {
                MessageBox.Show("Empty Name box.\n Please Enter Password.");
                passoword.Focus();
                return;
            }



        }
    }
}

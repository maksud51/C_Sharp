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
    public partial class SergentForm : Form
    {
        public SergentForm()
        {
            InitializeComponent();
        }

        private void checkRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckRegistration check_reg = new CheckRegistration();
            check_reg.Show();
        }

        private void alloteFine_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlloteFineForm allote_fine = new AlloteFineForm();
            allote_fine.Show();
        }

        private void speedBreakList_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpeedBreakList SpeedBrList = new SpeedBreakList();
            SpeedBrList.Show();
        }
    }
}

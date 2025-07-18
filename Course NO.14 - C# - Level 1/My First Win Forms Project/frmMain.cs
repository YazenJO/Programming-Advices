using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Win_Forms_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void btnShowMainDialog_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void btnShowMassageBox_Click(object sender, EventArgs e)
        {
            Form frm = new frmMassageBox();
            frm.ShowDialog();
        }
    }
}

using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            XtraForm1 form1 = new XtraForm1();
            form1.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            int PersonID = -1;
            if (int.TryParse(radTextBox1.Text,out PersonID))
            {
                frmKhara khara = new frmKhara(PersonID);
                khara.ShowDialog();
            }
            else
            {
                MessageBox.Show("Perosn ID Should Be A Number");
                radTextBox1.Clear();
                radTextBox1.Focus();
            }
            

        }
    }
}

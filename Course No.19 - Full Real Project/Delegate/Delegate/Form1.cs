using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.DataBack += Form2_DataBack;
            frm2.ShowDialog();
        }

        public void Form2_DataBack(object sender, int PersonID)
        {
            txtBox1.Text = PersonID.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraForm1 form1= new XtraForm1();
          
      
            form1.ShowDialog();
      
        }
    }
}
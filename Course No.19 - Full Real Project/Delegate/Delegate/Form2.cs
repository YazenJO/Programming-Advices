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
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public delegate void MyDelegate(object sender,int PersonID);

        public event MyDelegate DataBack;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSenData_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(txtBox1.Text);
            DataBack?.Invoke(this, PersonID);
            this.Close();
        }
    }
}
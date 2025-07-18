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

namespace DXApplication1
{
    public partial class frmKhara : DevExpress.XtraEditors.XtraForm
    {
         int _PersonID;
        public frmKhara(int PersonID )
        {
            InitializeComponent();
            this._PersonID = PersonID;
            
        }

        private void frmKhara_Load(object sender, EventArgs e)
        {
            lblID.Text= _PersonID.ToString();
        }
    }
}
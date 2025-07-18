using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPuzzle_Game
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        void ChangeImage(PictureEdit picture)
        {
            string newImageFileName = picture.Tag.ToString();

            // Change the image to the one that matches the tag
            picture.Image = Image.FromFile(@"C:\Users\yazen\Downloads\icons\10.png");


        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
           pic1.Image=Image.FromFile(@"C:\Users\yazen\Downloads\icons\10.png");



        }

        private void timeEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void numericChartRangeControlClient1_CustomizeSeries(object sender, DevExpress.XtraEditors.ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureEdit2_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged_2(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\yazen\Downloads\icons\10.png");
        }
    }
}

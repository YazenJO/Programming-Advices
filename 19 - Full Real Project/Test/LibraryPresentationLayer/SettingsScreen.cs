using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
       
        }
        
        private void _Load()
        {
              NBDefaultBorrowDays.Value=SettingsBL.GetDefualtBorrrowDays();
              NBumberLateFines.Value = SettingsBL.GetDefaultFinePerDay();
              NBExtendtBorrowDays.Value = SettingsBL.GetExtendedBorrowDays();
              NBActualLate.Value = SettingsBL.GetLateFineByDay();

        }

        private void guna2CirclePictureBox1_MouseHover_2(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.SetToolTip(guna2CirclePictureBox1, "Enter the fine amount for late returns. Adjust using the up/down arrows or type manually");

        }


        private void guna2CirclePictureBox2_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.SetToolTip(guna2CirclePictureBox2, "Enter the Default Borrow days . Adjust using the up/down arrows or type manually");

        }

        private void guna2CirclePictureBox3_MouseHover(object sender, EventArgs e)
        {
            guna2HtmlToolTip1.SetToolTip(guna2CirclePictureBox3, "Enter the Extendt Borrow Days. Adjust using the up/down arrows or type manually");

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private bool _Save()
        {
            bool UpdateDefaultBorrowDaysResult = SettingsBL.UpdateDefaultBorrowDays((int)NBDefaultBorrowDays.Value);
            bool UpdateDefaultFinePerDayResult = SettingsBL.UpdateDefaultFinePerDay((int)NBumberLateFines.Value);
            bool UpdateExtendedBorrowDaysResult = SettingsBL.UpdateExtendedBorrowDays((int)NBExtendtBorrowDays.Value);
            bool UpdateLateFineByDayResult = SettingsBL.UpdateLateFineByDay((int)NBActualLate.Value);
            if (UpdateDefaultBorrowDaysResult&&UpdateDefaultFinePerDayResult && UpdateExtendedBorrowDaysResult && UpdateLateFineByDayResult)
            {
                return true;
            }
            return false;
            
           
        }
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Save())
            {
                MessageBox.Show("Settings saved successfully!", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Faild To  Save Settings ","Error :(",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
            
           
           
        }

        
    }
}
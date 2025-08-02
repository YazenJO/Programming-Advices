using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management.LDApplication
{
    public partial class ManageLocalDrivingLicenseApplicationsScreen : Form
    {
        public enum enFilterBy
        {
            None,
            LocalDrivingLicenseAppID,
            NationalNo,
            FullName,
            Status
        }

        private readonly int _MainUserId;

        private enFilterBy _FilterBy;

        public ManageLocalDrivingLicenseApplicationsScreen(int UserID)
        {
            InitializeComponent();
            _MainUserId = UserID;
        }

        private void _RefreshLDLList()
        {
            LDLDataGridView1.DataSource = LocalDLApplicationBL.GetAllLocalDrivingLicenseApplications_View();
            lblNOfRecords.Text = LDLDataGridView1.RowCount.ToString();
        }

        private void _Load()
        {
            _RefreshLDLList();
        }

        private void ManageLocalDrivingLicenseApplicationsScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
            const int SpecialFilter = 4;

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefreshLDLList();
                txtFilter.Visible = false;
                grbStatus.Visible = false;
            }
            else if (cbFilter.SelectedIndex == SpecialFilter)
            {
                txtFilter.Visible = false;
                grbStatus.Visible = true;
            }
            else
            {
                txtFilter.Visible = true;
                grbStatus.Visible = false;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            switch ((enFilterBy)cbFilter.SelectedIndex)
            {
                case enFilterBy.None:
                    _RefreshLDLList();
                    break;

                case enFilterBy.LocalDrivingLicenseAppID:
                    LDLDataGridView1.DataSource =
                        LocalDLApplicationBL.GetFilterdLDLRecords("[L.D.LAppID]", txtFilter.Text);

                    break;

                case enFilterBy.NationalNo:
                    LDLDataGridView1.DataSource =
                        LocalDLApplicationBL.GetFilterdLDLRecords("NationalNo", txtFilter.Text);
                    break;

                case enFilterBy.FullName:
                    LDLDataGridView1.DataSource = LocalDLApplicationBL.GetFilterdLDLRecords("FullName", txtFilter.Text);
                    break;
            }
        }

        private void rdNew_CheckedChanged(object sender, EventArgs e)
        {
            LDLDataGridView1.DataSource = LocalDLApplicationBL.GetFilterdLDLRecords("[Application Status]", "New");
        }

        private void rdCanceled_CheckedChanged(object sender, EventArgs e)
        {
            LDLDataGridView1.DataSource = LocalDLApplicationBL.GetFilterdLDLRecords("[Application Status]", "Canceled");
        }

        private void rdConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            LDLDataGridView1.DataSource =
                LocalDLApplicationBL.GetFilterdLDLRecords("[Application Status]", "Completed");
        }

        private void DtimerFrom_ValueChanged(object sender, EventArgs e)
        {
            LDLDataGridView1.DataSource =
                LocalDLApplicationBL.GetLDLByApplicationDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void DttimeTo_ValueChanged(object sender, EventArgs e)
        {
            LDLDataGridView1.DataSource =
                LocalDLApplicationBL.GetLDLByApplicationDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void btnAddNewBorrow_Click(object sender, EventArgs e)
        {
            var newLdlScreen =
                new NewLocalDrivingLicenseApplicationScreen(_MainUserId);
            newLdlScreen.ShowDialog();
            _RefreshLDLList();
        }
    }
}
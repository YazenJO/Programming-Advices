using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class EditApplicationsTypeSceen : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        private readonly int _ManageAppTpeID;

        private readonly enMode _Mode;
        private ManageApplicationsTypesBL _manageApplicationsTypes;

        public EditApplicationsTypeSceen(int manageAppTpeID)
        {
            InitializeComponent();
            _ManageAppTpeID = manageAppTpeID;
            if (_ManageAppTpeID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void _Load()
        {
            if (_Mode == enMode.AddNew)
            {
                _manageApplicationsTypes = new ManageApplicationsTypesBL();
                return;
            }

            _manageApplicationsTypes = ManageApplicationsTypesBL.Find(_ManageAppTpeID);
            lblID.Text = _manageApplicationsTypes.ApplicationTypeID.ToString();
            txtTitle.Text = _manageApplicationsTypes.ApplicationTypeTitle;
            txtFees.Text = _manageApplicationsTypes.ApplicationFees.ToString();
        }

        private void EditApplicationsTypeSceen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _manageApplicationsTypes.ApplicationTypeTitle = txtTitle.Text;
            _manageApplicationsTypes.ApplicationFees = Convert.ToDecimal(txtFees.Text);
            if (_manageApplicationsTypes.Save())
                MessageBox.Show("Data Saved Successfully");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
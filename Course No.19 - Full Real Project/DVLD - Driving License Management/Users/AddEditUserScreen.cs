using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class AddEditUserScreen : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        private readonly enMode _Mode;
        private readonly int _UserID;
        private int _PersonID;

        private UserBL _User;

        public AddEditUserScreen(int userId)
        {
            InitializeComponent();
            _UserID = userId;
            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }


        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            _User.PersonID = _PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;
            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully");
                lblUserID.Text = _User.UserID.ToString();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlShowPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (UserBL.DoesUserExistByPersonID(_PersonID)) MessageBox.Show("This person already has an account.");
        }

        private void _UpdateMode()
        {
            lblState.Text = "Update User";
            ctrlShowPersonDetailsWithFilter1.LoadPersonDetails(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
        }

        private void _Load()
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new UserBL();
                lblState.Text = "Add New User";
                return;
            }

            _User = UserBL.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                Close();
            }

            _UpdateMode();
        }

        private void AddEditUserScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtUserName_Validated(object sender, EventArgs e)
        {
            if (UserBL.DoesUserNameExist(txtUserName.Text.Trim()))
            {
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "This UserName Already Exist");
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match");
            }
        }
    }
}
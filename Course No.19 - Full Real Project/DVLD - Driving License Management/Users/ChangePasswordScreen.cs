using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ChangePasswordScreen : Form
    {
        private readonly int _UserID;
        private UserBL _User;

        public ChangePasswordScreen(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void ChangePasswordScreen_Load(object sender, EventArgs e)
        {
            _User = UserBL.Find(_UserID);
            ctrlShowUserDetails1.LoadUserDetails(_UserID);
        }

        private void txtCurrentPassword_Validated(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Current Password is Incorrect");
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            _User.Password = txtConfirmPassword.Text.Trim();
            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully");
                Close();
            }
            else
            {
                MessageBox.Show("Password Save Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == _User.Password)
            {
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "New Password should be different from Current Password");
            }
        }
    }
}
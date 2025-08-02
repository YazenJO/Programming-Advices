using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ctrlShowUserDetails : UserControl
    {
        private UserBL _User;

        public ctrlShowUserDetails()
        {
            InitializeComponent();
        }

        public void LoadUserDetails(int UserID)
        {
            _User = UserBL.Find(UserID);
            ctrlShowPersonDetails1.LoadPersonDetails(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            switchIsActive.Checked = _User.IsActive;
        }

        private void ctrlShowUserDetails_Load(object sender, EventArgs e)
        {
        }
    }
}
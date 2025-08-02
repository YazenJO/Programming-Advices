using System;
using System.Windows.Forms;
using DVLD___Driving_License_Management.LDApplication;

namespace DVLD___Driving_License_Management
{
    public partial class MainScreen : Form
    {
        private int _MainUserID;

        public MainScreen(int UserId)
        {
            InitializeComponent();
            _MainUserID = UserId;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var managePeopleScreen = new ManagePeopleScreen(_MainUserID);
            managePeopleScreen.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MainUserID = -1;
            Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUserScreen = new ManageUserScreen(_MainUserID);
            manageUserScreen.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showUserDetailsScreen = new ShowUserDetailsScreen(_MainUserID);
            showUserDetailsScreen.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changePassword = new ChangePasswordScreen(_MainUserID);
            changePassword.Show();
        }

        private void drToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageApplicationTypesScreen = new ManageApplicationTypesScreen(_MainUserID);
            manageApplicationTypesScreen.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageTestTypesScreen = new ManageTestTypesScreen(_MainUserID);
            manageTestTypesScreen.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newDlScreen = new NewLocalDrivingLicenseApplicationScreen(_MainUserID);
            newDlScreen.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageldlScreen =
                new ManageLocalDrivingLicenseApplicationsScreen(_MainUserID);
            manageldlScreen.ShowDialog();
        }
    }
}
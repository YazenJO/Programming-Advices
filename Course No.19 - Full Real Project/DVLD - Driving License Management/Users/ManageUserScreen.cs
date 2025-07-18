using System;
using System.Linq;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ManageUserScreen : Form
    {
        private int _MainUserID;

        public ManageUserScreen(int UserID)
        {
            InitializeComponent();
            _MainUserID = UserID;
        }

        private void _RefreshUsersList()
        {
            UsersDataGridView1.DataSource = UserBL.GetUsers_View();
            lblNOfRecords.Text = UsersDataGridView1.RowCount.ToString();
        }

        private void _Load()
        {
            isActiveSwitch.Visible = false;
            _RefreshUsersList();
        }

        private void ManageUserScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
            const int SpecialFilter = 5;

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefreshUsersList();
                txtFilter.Visible = false;
                isActiveSwitch.Visible = false;
            }
            else if (cbFilter.SelectedIndex == SpecialFilter)
            {
                txtFilter.Visible = false;
                isActiveSwitch.Visible = true;
            }
            else
            {
                txtFilter.Clear();
                txtFilter.Visible = true;
                isActiveSwitch.Visible = false;
            }
        }

        private void _EnterJustADigits()
        {
            txtFilter.Text = new string(txtFilter.Text.Where(char.IsDigit).ToArray());
            txtFilter.SelectionStart = txtFilter.Text.Length;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    _RefreshUsersList();
                    break;

                case 1:
                    _EnterJustADigits();
                    UsersDataGridView1.DataSource = UserBL.GetFilterdUsers("UserID", txtFilter.Text);
                    break;

                case 2:
                    UsersDataGridView1.DataSource = UserBL.GetFilterdUsers("UserName", txtFilter.Text);
                    break;

                case 3:
                    _EnterJustADigits();
                    UsersDataGridView1.DataSource = UserBL.GetFilterdUsers("PersonID", txtFilter.Text);
                    break;

                case 4:
                    UsersDataGridView1.DataSource = UserBL.GetFilterdUsers("FullName", txtFilter.Text);
                    break;
            }
        }

        private void isActiveSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (isActiveSwitch.Checked)
            {
                UsersDataGridView1.DataSource = UserBL.GetFilterdUsers("IsActive", "1");
                return;
            }

            UsersDataGridView1.DataSource = UserBL.GetFilterdUsers("IsActive", "0");
        }

        private void btnAddNewBorrow_Click(object sender, EventArgs e)
        {
            var addEditUserScreen = new AddEditUserScreen(-1);
            addEditUserScreen.ShowDialog();
            _RefreshUsersList();
        }

        private void addNewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEditUserScreen = new AddEditUserScreen(-1);
            addEditUserScreen.ShowDialog();
            _RefreshUsersList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEditUserScreen = new AddEditUserScreen((int)UsersDataGridView1.CurrentRow.Cells[0].Value);
            addEditUserScreen.ShowDialog();
            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserBL.DeleteUser((int)UsersDataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show(" User Has Deleted Successfully ");
                _RefreshUsersList();
            }
            else
            {
                MessageBox.Show("User is not Deleted due to data connected to it ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Future Will Be Available Soon ");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Future Will Be Available Soon ");
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showUserDetailsScreen = new ShowUserDetailsScreen((int)UsersDataGridView1.CurrentRow.Cells[0].Value);
            showUserDetailsScreen.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changePasswordScreen =
                new ChangePasswordScreen((int)UsersDataGridView1.CurrentRow.Cells[0].Value);
            changePasswordScreen.ShowDialog();
        }
    }
}
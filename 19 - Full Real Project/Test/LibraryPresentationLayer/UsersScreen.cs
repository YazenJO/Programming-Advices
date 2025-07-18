using System;
using System.Windows.Forms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class UsersScreen : Form
    {
        private int _CurrentUserID;
        public UsersScreen(int UserID)
        {
            InitializeComponent();
            _CurrentUserID = UserID;
        }

        private void _RefeshUsersList()
        {
            UsersManagmentDataGrid.DataSource = UsersBL.GetUsers();
        }
        private void UsersScreen_Load(object sender, EventArgs e)
        {
            _RefeshUsersList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
            const int SpecialFilter = 4;

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefeshUsersList();
                txtFilter.Visible = false;
                grbGender.Visible = false;
            }
            else if (cbFilter.SelectedIndex == SpecialFilter)
            {
                txtFilter.Visible = false;
                grbGender.Visible = true;
            }
            else
            {
                txtFilter.Visible = true;
                grbGender.Visible = false;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                _RefeshUsersList();
            }

            if (cbFilter.SelectedIndex == 1)
            {
                UsersManagmentDataGrid.DataSource =
                    UsersBL.GetFilteredReaders("Name", txtFilter.Text);


            }
            else if (cbFilter.SelectedIndex == 2)
            {
                UsersManagmentDataGrid.DataSource =
                    UsersBL.GetFilteredReaders("Email", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                UsersManagmentDataGrid.DataSource =
                    UsersBL.GetFilteredReaders("Mobile", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 5)
            {
                UsersManagmentDataGrid.DataSource = UsersBL.GetFilteredReaders("Address", txtFilter.Text);
            }
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            UsersManagmentDataGrid.DataSource = UsersBL.GetReadersByGender("Female");
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            UsersManagmentDataGrid.DataSource = UsersBL.GetReadersByGender("Male");
        }

        private void DtimerFrom_ValueChanged(object sender, EventArgs e)
        {
            UsersManagmentDataGrid.DataSource = UsersBL.GetReadersBYBirthDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void DttimeTo_ValueChanged(object sender, EventArgs e)
        {
            UsersManagmentDataGrid.DataSource = UsersBL.GetReadersBYBirthDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddEditShowUserInfo addEditShowUserInfoScreen = new AddEditShowUserInfo(_CurrentUserID);
            addEditShowUserInfoScreen.ShowDialog();
            _RefeshUsersList();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddEditShowUserInfo addEditShowUserInfoScreen = new AddEditShowUserInfo(-1);
            addEditShowUserInfoScreen.ShowDialog();
            _RefeshUsersList();
        }

        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditShowUserInfo addEditShowUserInfoScreen = new AddEditShowUserInfo((int)UsersManagmentDataGrid.CurrentRow.Cells[0].Value,true);
            addEditShowUserInfoScreen.ShowDialog();
            _RefeshUsersList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEditShowUserInfo addEditShowUserInfoScreen = new AddEditShowUserInfo(-1);
            addEditShowUserInfoScreen.ShowDialog();
            _RefeshUsersList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditShowUserInfo addEditShowUserInfoScreen = new AddEditShowUserInfo((int)UsersManagmentDataGrid.CurrentRow.Cells[0].Value);
            addEditShowUserInfoScreen.ShowDialog();
            _RefeshUsersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CurrentUserID==(int)UsersManagmentDataGrid.CurrentRow.Cells[0].Value)
            {
                MessageBox.Show("Error: You cannot delete the currently logged-in user","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (BorrowsBL.DoesUserHaveBorrowingRecord((int)UsersManagmentDataGrid.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Error: This user cannot be deleted because they have an active borrowing record.","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure Wanna to delete this User?", "Are you sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (UsersBL.DeleteUser((int)UsersManagmentDataGrid.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User deleted successfully");
                    _RefeshUsersList();
                }
                else
                {
                    MessageBox.Show("Faild to  Delete The User","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
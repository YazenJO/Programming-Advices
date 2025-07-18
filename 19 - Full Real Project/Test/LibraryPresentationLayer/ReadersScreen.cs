using System;
using System.Windows.Forms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class ReadersScreen : Form
    {
        private int _UserID;

        public ReadersScreen(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void _RefreshReadersList()
        {
            ReadersManagmentDataGrid.DataSource = UsersBL.GetReaders();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
            const int SpecialFilter = 4;

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefreshReadersList();
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

        private void ReadersScreen_Load(object sender, EventArgs e)
        {
            _RefreshReadersList();
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ReadersManagmentDataGrid.DataSource = UsersBL.GetReadersByGender("Female");

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                _RefreshReadersList();
            }

            if (cbFilter.SelectedIndex == 1)
            {
                ReadersManagmentDataGrid.DataSource =
                    UsersBL.GetFilteredReaders("Name", txtFilter.Text);


            }
            else if (cbFilter.SelectedIndex == 2)
            {
                ReadersManagmentDataGrid.DataSource =
                    UsersBL.GetFilteredReaders("Email", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                ReadersManagmentDataGrid.DataSource =
                    UsersBL.GetFilteredReaders("Mobile", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 5)
            {
                ReadersManagmentDataGrid.DataSource = UsersBL.GetFilteredReaders("Address", txtFilter.Text);
            }
        }

        private void grbGender_Enter(object sender, EventArgs e)
        {

        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            ReadersManagmentDataGrid.DataSource = UsersBL.GetReadersByGender("Male");

        }

        private void DtimerFrom_ValueChanged_1(object sender, EventArgs e)
        {
            ReadersManagmentDataGrid.DataSource = UsersBL.GetReadersBYBirthDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void DttimeTo_ValueChanged(object sender, EventArgs e)
        {
            ReadersManagmentDataGrid.DataSource = UsersBL.GetReadersBYBirthDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Readers","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddReader ReadersScreen = new AddReader(-1);
            ReadersScreen.Show();
        }

        private void toolStripAddReader_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Readers","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddReader ReadersScreen = new AddReader(-1);
            ReadersScreen.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Readers","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddReader ReadersScreen = new AddReader(-1);
            ReadersScreen.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Readers","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddReader ReadersScreen = new AddReader((int)ReadersManagmentDataGrid.CurrentRow.Cells[0].Value);
            ReadersScreen.Show();
            _RefreshReadersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_UserID==(int)ReadersManagmentDataGrid.CurrentRow.Cells[0].Value)
            {
                MessageBox.Show("Error: You cannot delete the currently logged-in Reader","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (BorrowsBL.DoesUserHaveBorrowingRecord((int)ReadersManagmentDataGrid.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Error: This Reader cannot be deleted because they have an active borrowing record.","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Readers","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            if (MessageBox.Show("Are you sure you want to delete this Reader", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (UsersBL.DeleteUser((int)ReadersManagmentDataGrid.CurrentRow.Cells[0].Value))

                    MessageBox.Show("Book deleted successfully");
                else

                    MessageBox.Show("Failed to delete Book");
                _RefreshReadersList();
            }
        }
    }
}
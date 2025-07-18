using System;
using System.Windows.Forms;
using LibraryBusnissLayer;
using LibraryBusnissLayer.Properties;

namespace Test
{
    public partial class BooksScreen : Form
    {
        private int _UserID;
        public BooksScreen(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void _RefreshBookList()
        {
            BooksManagmentDataGrid.DataSource = BooksBL.GetAllBooks();
        }
        private void BooksScreen_Load(object sender, EventArgs e)
        {
            _RefreshBookList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
            const int SpecialFilter = 4;

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefreshBookList();
                txtFilter.Visible = false;
                AvailabilitySwitch.Visible = false;
            }
            else if (cbFilter.SelectedIndex == SpecialFilter)
            {
                txtFilter.Visible = false;
                AvailabilitySwitch.Visible = true;
            }
            else
            {
                txtFilter.Visible = true;
                AvailabilitySwitch.Visible = false;
            }
            

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                _RefreshBookList();
            }

            if (cbFilter.SelectedIndex == 1)
            {
                BooksManagmentDataGrid.DataSource =
                    BooksBL.GetFilterdBooks("Title", txtFilter.Text);


            }
            else if (cbFilter.SelectedIndex == 2)
            {
                BooksManagmentDataGrid.DataSource =
                    BooksBL.GetFilterdBooks("Genre", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                BooksManagmentDataGrid.DataSource =
                    BooksBL.GetFilterdBooks("ISBN", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 4)
            {
                BooksBL.GetFilterdBooks("Authorname", txtFilter.Text);
            }
        }

        private void AvailabilitySwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (AvailabilitySwitch.Checked)
            {
              
                BooksManagmentDataGrid.DataSource =
                    BookCopiesBL.GetAvailableCopies();
            }
            else
            {
               
                BooksManagmentDataGrid.DataSource =
                    BookCopiesBL.GetNotAvailableCopies();
                    
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 0)
            {
                _RefreshBookList();

            }

            if (cbStatus.SelectedIndex == 1)
            {

                BooksManagmentDataGrid.DataSource = BooksBL.GetdBookLanguage("Arabic");

            }

            if (cbStatus.SelectedIndex == 2)
            {
                BooksManagmentDataGrid.DataSource = BooksBL.GetdBookLanguage("English");;

            }
        }

        private void DtimerFrom_ValueChanged(object sender, EventArgs e)
        {
            BooksManagmentDataGrid.DataSource = BooksBL.GetBooksByPublishDateDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void DttimeTo_ValueChanged(object sender, EventArgs e)
        {
            BooksManagmentDataGrid.DataSource = BooksBL.GetBooksByPublishDateDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageBooks"))
            {
                MessageBox.Show("You do not have permission to manage books","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddBookScreen AddBookcS=new AddBookScreen(-1,_UserID);
            AddBookcS.ShowDialog();
            _RefreshBookList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageBooks"))
            {
                MessageBox.Show("You do not have permission to manage books","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddBookScreen AddBookcS=new AddBookScreen(-1,_UserID);
            AddBookcS.ShowDialog();
            _RefreshBookList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageBooks"))
            {
                MessageBox.Show("You do not have permission to manage books","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddBookScreen AddBookcS = new AddBookScreen((int)BooksManagmentDataGrid.CurrentRow.Cells[0].Value,_UserID);
            AddBookcS.ShowDialog();
            _RefreshBookList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageBooks"))
            {
                MessageBox.Show("You do not have permission to manage books","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            if (MessageBox.Show("Are you sure you want to delete this book","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                if (BooksBL.DeleteBooks((int)BooksManagmentDataGrid.CurrentRow.Cells[0].Value))
                
                    MessageBox.Show("Book deleted successfully");
                else
                
                    MessageBox.Show("Failed to delete Book");
                _RefreshBookList();
                
            }
        }

       
    }
}
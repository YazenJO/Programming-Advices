using System;
using System.ComponentModel;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LibraryBusnissLayer;
using LibraryBusnissLayer.Properties;

namespace Test
{
    public partial class Borrows : Form
    {
        private int _UserID;
       

        public Borrows(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

        }


        private void _RefreshBorrowList()
        {
            BorrowDataGridView1.DataSource = BorrowsBL.GetBorrowingRecords();

        }

        private void Borrows_Load(object sender, EventArgs e)
        {
            _RefreshBorrowList();
        }


        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 0)
            {
                _RefreshBorrowList();

            }

            if (cbStatus.SelectedIndex == 1)
            {

                BorrowDataGridView1.DataSource = BorrowsBL.GetOnTimeBorrowingRecords();

            }

            if (cbStatus.SelectedIndex == 2)
            {
                BorrowDataGridView1.DataSource = BorrowsBL.GetOverdueBorrowingRecords();

            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                _RefreshBorrowList();
            }

            if (cbFilter.SelectedIndex == 1)
            {
                BorrowDataGridView1.DataSource =
                    BooksBL.GetFilterdBooks("Title", txtFilter.Text);


            }
            else if (cbFilter.SelectedIndex == 2)
            {
                BorrowDataGridView1.DataSource =
                    BooksBL.GetFilterdBooks("Genre", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                BorrowDataGridView1.DataSource =
                    BooksBL.GetFilterdBooks("ISBN", txtFilter.Text);
            }
           
        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
            const int SpecialFilter = 4;

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefreshBorrowList();
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


        private void DtimerFrom_ValueChanged(object sender, EventArgs e)
        {
            BorrowDataGridView1.DataSource = BorrowsBL.GetBorrowingRecordsByDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void DttimeTo_ValueChanged(object sender, EventArgs e)
        {
            BorrowDataGridView1.DataSource = BorrowsBL.GetBorrowingRecordsByDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void btnAddNewBorrow_Click(object sender, EventArgs e)
        {
            AddBorrowsScreen AddBorrowsScreen = new AddBorrowsScreen(-1,_UserID);
            AddBorrowsScreen.ShowDialog();
            _RefreshBorrowList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddBorrowsScreen AddBorrowsScreen = new AddBorrowsScreen(-1,_UserID);
            AddBorrowsScreen.ShowDialog();
            _RefreshBorrowList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ShowEditBorrowScreen ShowEditBorrowScreen = new ShowEditBorrowScreen((int)BorrowDataGridView1.CurrentRow.Cells[0].Value,false);
            ShowEditBorrowScreen.ShowDialog();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinesBl Fines = new FinesBl();
            if (BorrowsBL.ReturnBook((int)BorrowDataGridView1.CurrentRow.Cells[0].Value, ref Fines))
            {
                if (MessageBox.Show(
                        "Book Returned Successfully,You Should To PAY [" + Fines.FineAmount + " JD] ",
                        "ReturnBook", MessageBoxButtons.OK
                        , MessageBoxIcon.Information) == DialogResult.OK)
                {
                   
                    Fines.PaymentStatus = true;
                    PaymentsBL Payment = new PaymentsBL();
                    Payment.ReaderID = BorrowsBL.GetUserIdByBorrowId((int)BorrowDataGridView1.CurrentRow.Cells[0].Value) ;
                    Payment.UserID = _UserID;
                    Payment.PaymymentDate = DateTime.Now;
                    Payment.PaymentAmount = Fines.FineAmount;
                    if (Payment.Save())
                    {
                        if (Fines.Save())
                        MessageBox.Show("Payment Completed", "Successefully Payment", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Payment ", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }



                _RefreshBorrowList();
            }
            else
            {
                MessageBox.Show("Return Failed :(", "Return Failed", MessageBoxButtons.OK);
            }



        }

        private void extendDueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            BorrowsBL Borrow=BorrowsBL.Find((int)BorrowDataGridView1.CurrentRow.Cells[0].Value);
            if (BookCopiesBL.IsCopyAvailable(Borrow.CopyID))
            {
                MessageBox.Show("Cant Extend Borrow For A Returned Copy", "Extend Faild", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Borrow.DueDate=Borrow.DueDate.AddDays(SettingsBL.GetExtendedBorrowDays());
            
                if (Borrow.Save())
                {
                    MessageBox.Show("Borrow Exteneded For ["+SettingsBL.GetExtendedBorrowDays()+"]");
                }
               
            
            else
            {
                MessageBox.Show("Extend Borrow Days Faild");
            }
            _RefreshBorrowList();
            
        }

        private void AvailabilitySwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (AvailabilitySwitch.Checked)
            {
              
                BorrowDataGridView1.DataSource =
                    BookCopiesBL.GetAvailableCopies();
            }
            else
            {
               
                BorrowDataGridView1.DataSource =
                    BookCopiesBL.GetNotAvailableCopies();
                    
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID, "ManageBorrow"))
            {
                MessageBox.Show("You do not have permission to manage Borrows","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ShowEditBorrowScreen ShowEditBorrowScreen = new ShowEditBorrowScreen((int)BorrowDataGridView1.CurrentRow.Cells[0].Value,true);
            ShowEditBorrowScreen.ShowDialog();
            _RefreshBorrowList();
           
        }


        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageBorrow"))
            {
                MessageBox.Show("You do not have permission to Delete Borrows","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this Record", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BorrowsBL.DeleteBorrowingRecord((int)BorrowDataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Record Deleted Successfully");
                    _RefreshBorrowList();
                }
                else
                {
                    MessageBox.Show("Please clear any outstanding fines on this record before proceeding with deletion.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

             
            }

        }
    }
}



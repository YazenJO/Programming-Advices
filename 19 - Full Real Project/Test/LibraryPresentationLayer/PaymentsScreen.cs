using System;
using System.Windows.Forms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class PaymentsScreen : Form
    {
        private int _UserId;
        public PaymentsScreen(int UserID)
        {
            _UserId = UserID;
            InitializeComponent();
        }

        private void _RefreshPaymentsList()
        {
            PaymentsManagmentDataGrid.DataSource = PaymentsBL.GetPayments();
        }
        private void PaymentsScreen_Load(object sender, EventArgs e)
        {
            _RefreshPaymentsList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
          

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefreshPaymentsList();
                txtFilter.Visible = false;
                
            }
            else
            {
                txtFilter.Visible = true;
               
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                _RefreshPaymentsList();
            }

            if (cbFilter.SelectedIndex == 1)
            {
                PaymentsManagmentDataGrid.DataSource =
                    PaymentsBL.GetFilteredPayments("Name", txtFilter.Text);


            }
            else if (cbFilter.SelectedIndex == 2)
            {
                PaymentsManagmentDataGrid.DataSource =
                    PaymentsBL.GetFilteredPayments("PaymentAmount", txtFilter.Text);
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                PaymentsManagmentDataGrid.DataSource =
                    PaymentsBL.GetFilteredPayments("PaidByUser", txtFilter.Text);
            }
         
        }

        private void DtimerFrom_ValueChanged(object sender, EventArgs e)
        {
            PaymentsManagmentDataGrid.DataSource = PaymentsBL.GetPaymentsBYBirthDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void DttimeTo_ValueChanged(object sender, EventArgs e)
        {
            PaymentsManagmentDataGrid.DataSource = PaymentsBL.GetPaymentsBYBirthDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserId,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Payments","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddNewPayment AddNewPayment = new AddNewPayment(-1);
            AddNewPayment.ShowDialog();
            _RefreshPaymentsList();
        }

        private void AddtoolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            if (!UsersBL.ChckAccessPermission(_UserId,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Payments","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddNewPayment AddNewPayment = new AddNewPayment(-1,_UserId);
            AddNewPayment.ShowDialog();
            _RefreshPaymentsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserId,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Payments","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            AddNewPayment AddNewPayment = new AddNewPayment((int)PaymentsManagmentDataGrid.CurrentRow.Cells[0].Value);
            
            AddNewPayment.ShowDialog();
            _RefreshPaymentsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserId,"ManageReaders"))
            {
                MessageBox.Show("You do not have permission to manage Payments","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            if (MessageBox.Show("Are you sure you want to delete this Payment", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (PaymentsBL.DeletePayment((int)PaymentsManagmentDataGrid.CurrentRow.Cells[0].Value))

                    MessageBox.Show("Payment deleted successfully");
                else

                    MessageBox.Show("Failed to Payment Book");
                _RefreshPaymentsList();
            }
        }
    }
}
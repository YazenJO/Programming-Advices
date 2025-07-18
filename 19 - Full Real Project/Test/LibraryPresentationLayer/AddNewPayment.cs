using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class AddNewPayment : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        private int _UserID;
        private enMode _Mode;
        private int _PaymentID;
        private PaymentsBL Payment;
        public AddNewPayment(int PaymentID,int UserID=1)
        {
            InitializeComponent();
            _PaymentID = PaymentID;
            _UserID = UserID;
            if (_PaymentID==-1)
            
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;
                
            
            
        }

        private void _FillReaderComboBox()
        {
            DataTable dt = UsersBL.GetUsers();
            foreach (DataRow row in dt.Rows)
            {
                cbReaderInfo.Items.Add($"{row["Name"],-20} {row["LibraryCardNumber"]}");
                ;
            }
            
        }

        private void _FillData()
        {
          
            cbReaderInfo.SelectedIndex = cbReaderInfo.FindString(UsersBL.Find(Payment.ReaderID).Name);
            NbPaymentAmount.Value = Payment.PaymentAmount;
            dtDateOfPayment.Value = Payment.PaymymentDate;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                Payment = new PaymentsBL();
                return;
            }
            Payment = PaymentsBL.Find(_PaymentID);
            _FillData();
        }
        private void AddNewPayment_Load(object sender, EventArgs e)
        {
            _FillReaderComboBox();
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string LibrarycardN = default;
            if (cbReaderInfo.SelectedItem != null)
            {
                string selectedText = cbReaderInfo.SelectedItem.ToString();
                string[] parts = selectedText.Trim().Split(' '); // Split by spaces

                string libraryCardNumber = parts.Last();
                LibrarycardN = libraryCardNumber;

            }
           Payment.UserID = _UserID;
            Payment.ReaderID = UsersBL.FindBYLibraryCardNumber(LibrarycardN).UserID;
            Payment.PaymentAmount = (decimal)NbPaymentAmount.Value;
            Payment.PaymymentDate = dtDateOfPayment.Value;
            if (Payment.Save())
            {
                MessageBox.Show("Payment Information Updated Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Faild To Update Payment Information ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
            }
            
            
        }
    }
}
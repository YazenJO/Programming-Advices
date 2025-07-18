using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class ShowEditBorrowScreen : Form
    {

        private int _BorrowID;
        private BorrowsBL.BorrowingViewBL _Borrow;


        public ShowEditBorrowScreen(int BorrowID, bool EditMode)
        {
            InitializeComponent();
            _BorrowID = BorrowID;
            _Borrow = BorrowsBL.BorrowingViewBL.Find(_BorrowID);
            if (EditMode)
                _Borrow.Mode = BorrowsBL.BorrowingViewBL.enMode.Edit;
            else
                _Borrow.Mode = BorrowsBL.BorrowingViewBL.enMode.ShowMode;



        }

        private void _LoadDataInTextBoxes()
        {
            if (_Borrow != null)
            {
                int UserID = BorrowsBL.GetUserIdByBorrowId(_BorrowID);

                //txtUserName.Text =_Borrow.UserName;
                cbUsersList.SelectedIndex = cbUsersList.FindString(UsersBL.Find(UserID).Name);
                dtBorrowingDate.Value = _Borrow.BorrowingDate;
                dtDueDate.Value = _Borrow.DueDate;
                if (_Borrow.ActualReturnDate == null)
                {
                    dtActualReturnDate.FillColor = Color.Silver;
                    dtActualReturnDate.Checked = false;
                }

                else
                {
                    dtActualReturnDate.Checked = true;
                    dtActualReturnDate.Value = (DateTime)_Borrow.ActualReturnDate;
                }
                if (_Borrow.PaymentStatus != null || _Borrow.PaymentStatus == true)
                    chkPayment.Checked = true;
                else
                    chkPayment.Checked = false;
            }
            else
            {
                MessageBox.Show("Unable to retrieve borrow information", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void _ShowDataMode()
        {

            cbUsersList.Enabled = false;

           
            picMode.Image = Properties.Resources.Show_Details;
            // txtUserName.ReadOnly=true;
            dtBorrowingDate.Enabled = false;
            dtDueDate.Enabled = false;
            dtActualReturnDate.Enabled = false;
            chkPayment.Enabled = false;
            btnSave.Visible = false;
        }

        private void _EditMode()
        {
            cbUsersList.Enabled = true;
            
            picMode.Image = Properties.Resources.Edit_Borrow;
            // txtUserName.ReadOnly=false;
            dtBorrowingDate.Enabled = true;
            dtDueDate.Enabled = true;
            chkPayment.Enabled = true;
            btnSave.Visible = true;
        }


        private void _LoadData()
        {
            _FillUsersinComboBox();
            _LoadDataInTextBoxes();
            if (_Borrow.Mode == BorrowsBL.BorrowingViewBL.enMode.ShowMode)
            {
                _ShowDataMode();
                return;
            }

            _EditMode();
            return;


        }


        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ShowEditBorrowScreen_Load(object sender, EventArgs e)
        {
            EnhanceUI();
            _LoadData();
        }

        private void EnhanceUI()
        {
            // Apply Rounded Corners and Shadows to Textboxes
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2TextBox textBox)
                {
                    textBox.BorderRadius = 8;
                    textBox.ShadowDecoration.Enabled = true;
                    textBox.ShadowDecoration.Depth = 5;
                }
                else if (ctrl is Guna.UI2.WinForms.Guna2Button button)
                {
                    button.BorderRadius = 12;
                    button.ShadowDecoration.Enabled = true;
                    button.HoverState.FillColor = Color.LightGray;
                }
            }

         
          


            // Set Background Gradient
            this.BackColor = Color.White;
            Guna.UI2.WinForms.Guna2GradientPanel bgPanel = new Guna.UI2.WinForms.Guna2GradientPanel
            {
                Dock = DockStyle.Fill,
                FillColor = Color.LightBlue,
                FillColor2 = Color.White,
                GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal,
            };
            this.Controls.Add(bgPanel);
            bgPanel.SendToBack();

            // Add Icons to TextBoxes
            //txtUserName.IconLeft = Properties.Resources.ID;


            // Replace Checkbox with Toggle Switch
            Guna.UI2.WinForms.Guna2ToggleSwitch togglePayment = new Guna.UI2.WinForms.Guna2ToggleSwitch
            {
                Location = chkPayment.Location,
                Size = chkPayment.Size,

            };
            this.Controls.Add(togglePayment);


            // Apply Hover Effects to Buttons
            btnSave.HoverState.FillColor = Color.LightGreen;
            btnSave.HoverState.BorderColor = Color.DarkGreen;
            btnSave.HoverState.ForeColor = Color.White;

            // Add Animation to Title
            Guna.UI2.WinForms.Guna2Transition transition = new Guna.UI2.WinForms.Guna2Transition();
           
        }

        private void _FillUsersinComboBox()
        {
            DataTable dtUsers = UsersBL.GetUsers();

            foreach (DataRow row in dtUsers.Rows)
            {

                cbUsersList.Items.Add($"{row["Name"],-20} {row["LibraryCardNumber"]}");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMode_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string LibrarycardN = default;
            if (cbUsersList.SelectedItem != null)
            {
                string selectedText = cbUsersList.SelectedItem.ToString();
                string[] parts = selectedText.Trim().Split(' '); // Split by spaces

                string libraryCardNumber = parts.Last();
                LibrarycardN = libraryCardNumber;

            }


            FinesBl Fine = FinesBl.FindByBorrowId(_BorrowID);
            BorrowsBL OBorrow = BorrowsBL.Find(_BorrowID);
            OBorrow.UserID = UsersBL.FindBYLibraryCardNumber(LibrarycardN).UserID;
            OBorrow.BorrowingDate = dtBorrowingDate.Value;
            OBorrow.DueDate = dtDueDate.Value;
            if (dtActualReturnDate.Checked == false)
            {
                if (MessageBox.Show("Invalid Actual Return Date detected. Would you like to leave it empty?",
                        "Invalid Date Detected – Keep it Empty?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    OBorrow.ActualReturnDate = null;

                }

            }
            else
            {
                OBorrow.ActualReturnDate = dtActualReturnDate.Value;
            }


            if (OBorrow.Save())
            {
                MessageBox.Show("Borrow Information Updated Successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Borrow Information Updated Failurefully", "Failure", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }


        }

        private void cbUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtActualReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void chkPayment_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

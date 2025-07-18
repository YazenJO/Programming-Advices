using System;
using System.Windows.Forms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class AddEditShowUserInfo : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1,
            Display = 2
        };

        private enMode _Mode;
        private int _UserId;
        UsersBL _User;

        public AddEditShowUserInfo(int UserID, bool Displaymood = false)
        {
            InitializeComponent();
            _UserId = UserID;

            if (_UserId == -1)
                _Mode = enMode.AddNew;
            else if (Displaymood)
            {
                _Mode = enMode.Display;
                return;
            }
            else
                _Mode = enMode.Update;
        }


        private void _FillPermissionsCheckBoxes()
        {
            if (UsersBL.ChckAccessPermission(_UserId, "FullAccess"))
            {
                chkFullAccess.Checked = true;
                chkManageBooks.Checked = true;
                chkManageReaders.Checked = true;
                chkManageUseers.Checked = true;
                chkManageBorrows.Checked = true;
                chkManagePayments.Checked = true;
                chkManageSettings.Checked = true;
                return;
            }

            if (UsersBL.ChckAccessPermission(_UserId, "ManageReaders"))
            {
                chkManageReaders.Checked = true;
            }

            if (UsersBL.ChckAccessPermission(_UserId, "ManageBooks"))
            {
                chkManageBooks.Checked = true;
            }

            if (UsersBL.ChckAccessPermission(_UserId, "ManageUsers"))
            {
                chkManageUseers.Checked = true;
            }

            if (UsersBL.ChckAccessPermission(_UserId, "ManagePayments"))
            {
                chkManagePayments.Checked = true;
            }

            if (UsersBL.ChckAccessPermission(_UserId, "LibrarySettings"))
            {
                chkManageSettings.Checked = true;
            }
            if (UsersBL.ChckAccessPermission(_UserId, "ManageBorrow"))
            {
                chkManageSettings.Checked = true;
            }
        }

        private void _FillData()
        {
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.Name;
            txtEmail.Text = _User.Email;
            txtMobile.Text = _User.Mobile;
            txtAddress.Text = _User.Address;
            txtContactInformation.Text = _User.ContactInformation;
            dtDateOfBirth.Value = _User.DateOfBrith;
            txtFacebook.Text = _User.Facebook;
            txtEditUserName.Text = _User.Name;
            txtEditLibraryCardNumber.Text = _User.LibraryCardNumber;
            if (_User.ImageLocation != "")
            {
                picUser.Load(_User.ImageLocation);
            }

            if (_User.Gender.Trim() == "Male")
            {
                rdMale.Checked = true;
            }
            else
            {
                rdMale.Checked = true;
            }

            _FillPermissionsCheckBoxes();
        }

        private void _DisplayMode()
        {
            btnAdd.Visible = false;
            btnRemove.Visible = false;
            btnSave.Visible = false;
            txtUserName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtMobile.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtContactInformation.ReadOnly = true;
            dtDateOfBirth.Enabled = false;
            txtFacebook.ReadOnly = true;
            rdMale.Enabled = false;
            rdFemale.Enabled = false;
            txtEditUserName.Enabled = false;
            txtEditLibraryCardNumber.Enabled = false;
            chkFullAccess.Enabled = false;
            chkManageBooks.Enabled = false;
            chkManageReaders.Enabled = false;
            chkManagePayments.Enabled = false;
            chkManageSettings.Enabled = false;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new UsersBL();
                return;
            }


            _User = UsersBL.Find(_UserId);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserId);
                this.Close();

                return;
            }
            else if (_Mode == enMode.Display)
            {
                _DisplayMode();
            }

            _FillData();
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
        }

        private void AddEditShowUserInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _CountPermissionValue()
        {
            int PermissionValue = 0;
            if ((chkFullAccess.Checked))
            {

                return -1;
            }
            if (chkManageReaders.Checked) PermissionValue |= 1;
            if (chkManageBooks.Checked) PermissionValue |= 2;
            if (chkManageUseers.Checked) PermissionValue |= 4;
            if (chkManagePayments.Checked) PermissionValue |= 16;
            if (chkManageSettings.Checked) PermissionValue |= 32;
            if (chkManageBorrows.Checked) PermissionValue |= 64;
            
            return PermissionValue;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int PermissionValue = _CountPermissionValue();
            _User.Name = txtUserName.Text;
            _User.Email = txtEmail.Text;
            _User.Mobile = txtMobile.Text;
            _User.Address = txtAddress.Text;
            _User.ContactInformation = txtContactInformation.Text;
            _User.DateOfBrith = dtDateOfBirth.Value;
            _User.Facebook = txtFacebook.Text;
            _User.Name = txtEditUserName.Text;
            if (UsersBL.DoesUserExist(txtEditLibraryCardNumber.Text)&&_Mode==enMode.AddNew)
            {
                MessageBox.Show("This Library Card Number is already in use");
                return;
            }
            _User.LibraryCardNumber=txtEditLibraryCardNumber.Text;
            _User.Permissions = PermissionValue;
            if (picUser.ImageLocation != null)
            {
                _User.ImageLocation = picUser.ImageLocation;
            }
            else
            {
                _User.ImageLocation = "";
            }

            if (_User.Save())
            {
                MessageBox.Show("User Information Saved Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Save User Information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void chkFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullAccess.Checked)
            {
                chkManageBooks.Checked = true;
                chkManageReaders.Checked = true;
                chkManageUseers.Checked = true;
                chkManagePayments.Checked = true;
                chkManageSettings.Checked = true;
            }
            else
            {
                chkManageBooks.Checked = false;
                chkManageReaders.Checked = false;
                chkManageUseers.Checked = false;
                chkManagePayments.Checked = false;
                chkManageSettings.Checked = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picUser.ImageLocation = null;
            btnRemove.Visible = false;
        }

        private void picUser_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                picUser.Load(selectedFilePath);

            }
        }
    }
}
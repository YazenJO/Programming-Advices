using System;
using System.Windows.Forms;
using LibraryBusnissLayer;
using Telerik.WinControls.FileDialogs;

namespace Test
{
    public partial class AddReader : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        private enMode _Mode;
        private int _ReaderID;
        UsersBL _Reader;

        public AddReader(int ReaderID)
        {
            InitializeComponent();

            _ReaderID = ReaderID;
            if (_ReaderID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }

        private void _FillTextBoxes()
        {
            txtName.Text = _Reader.Name;
            txtMobile.Text = _Reader.Mobile;
            txtEmail.Text = _Reader.Email;
            txtFacebook.Text = _Reader.Facebook;
            dtDateOfBirth.Value = _Reader.DateOfBrith;
            txtAddress.Text = _Reader.Address;
            txtLibraryCard.Text = _Reader.LibraryCardNumber;
            txtAddress.Text = _Reader.Address;
            txtContactInfo.Text = _Reader.ContactInformation;
            if (_Reader.ImageLocation != "")
            {
                picboxReader.Load(_Reader.ImageLocation);
            }

            btnRemove.Visible = (_Reader.ImageLocation != "");
            cbGender.SelectedIndex = cbGender.FindString(_Reader.Gender.Trim());
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Reader = new UsersBL();
                return;
            }

            _Reader = UsersBL.Find(_ReaderID);

            if (_Reader == null)
            {
                MessageBox.Show("This form will be closed because No Reader with ID = " + _ReaderID);
                this.Close();

                return;
            }

            _FillTextBoxes();

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void AddReader_Load(object sender, EventArgs e)
        {
            _LoadData();
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

                picboxReader.Load(selectedFilePath);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Reader.Name = txtName.Text;
            _Reader.Mobile = txtMobile.Text;
            _Reader.Email = txtEmail.Text;
            _Reader.Facebook = txtFacebook.Text;
            _Reader.DateOfBrith = dtDateOfBirth.Value;
            _Reader.Address = txtAddress.Text;
            if (UsersBL.DoesUserExist(txtLibraryCard.Text)&&_Mode==enMode.AddNew)
            {
                MessageBox.Show("This Library Card Number is already in use");
                return;
            }
            _Reader.LibraryCardNumber = txtLibraryCard.Text;
            _Reader.Gender = cbGender.SelectedItem.ToString();
            if (picboxReader.ImageLocation != null)
            {
                _Reader.ImageLocation = picboxReader.ImageLocation;
            }
            else
            {
                _Reader.ImageLocation = "";
            }

            if (_Reader.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
            this.Close();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picboxReader.ImageLocation = null;
            btnRemove.Visible = false;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class AddEdit_Person_Info : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        private readonly int _PersonID;

        private enMode _Mode;
        private PersonBL _Person;

        public AddEdit_Person_Info(int PersonId)
        {
            InitializeComponent();
            _PersonID = PersonId;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        public event DataBackEventHandler DataBack;

        private void _FillCountryCombobox()
        {
            var dt = CountryBL.GetCountries();
            foreach (DataRow row in dt.Rows) cbCountries.Items.Add($"{row["CountryName"]}");
        }

        private void _LoadImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        // Load image into memory and release the lock
                        picPersonImage.Image = Image.FromStream(stream);
                    }

                    picPersonImage.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void _FillData()
        {
            lblPersonID.Text = _Person.PersonID.ToString();
            txtNationalNo.Text = _Person.NationalNo;
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            dtDateOfBirth.Value = _Person.DateOfBirth;
            txtAddress.Text = _Person.Address;
            cbCountries.SelectedIndex =
                cbCountries.FindString(CountryBL.Find(_Person.NationalityCountryID).CountryName);
            if (_Person.Gendor == 0)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;

            _LoadImage(_Person.ImagePath);
        }

        private void _Load()
        {
            _FillCountryCombobox();
            if (_Mode == enMode.AddNew)
            {
                _Person = new PersonBL();
                return;
            }

            _Person = PersonBL.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                Close();
            }

            _FillData();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void AddEdit_Person_Info_Load(object sender, EventArgs e)
        {
            _Load();
        }

        public static void DeleteImage(PictureBox pictureBox, HyperlinkLabelControl removeLabel)
        {
            try
            {
                if (pictureBox.Image != null && !string.IsNullOrEmpty(pictureBox.ImageLocation))
                {
                    var imagePath = pictureBox.ImageLocation;

                    // Dispose of the image to release the lock
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                    pictureBox.ImageLocation = null;

                    // Delete the image file
                    if (File.Exists(imagePath)) File.Delete(imagePath);

                    // Hide the remove label
                    removeLabel.Visible = false;

                    MessageBox.Show("Image successfully deleted.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No image to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void hlblRemove_Click(object sender, EventArgs e)
        {
            DeleteImage(picPersonImage, hlblRemove);
            // hlblRemove.Visible = false;
        }

        private void hblbSetImage_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                var selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                picPersonImage.Load(selectedFilePath);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string _ChangeNameAndMoveImageToAnotherFile()
        {
            var newImagePath = "";

            var newGuid = Guid.NewGuid();
            try
            {
                if (picPersonImage.Image == null)
                {
                    MessageBox.Show("No image is loaded in the PictureBox.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return "";
                }

                // Get the image location (if it's loaded from a file)
                if (picPersonImage.ImageLocation == null)
                {
                    MessageBox.Show("Image location is not available. Load the image from a file.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                var sourcePath = picPersonImage.ImageLocation;
                var destinationFolder =
                    @"E:\C++\C++\Course No.19 - Full Real Project\DVLD - Driving License Management\SavedProfiles";

                // Ensure the destination folder exists
                if (!Directory.Exists(destinationFolder)) Directory.CreateDirectory(destinationFolder);

                // Set the new file name with the same extension
                var newFilePath =
                    Path.Combine(destinationFolder, newGuid + Path.GetExtension(sourcePath));
                newImagePath = newFilePath;
                // copy the file
                File.Copy(sourcePath, newFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return newImagePath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PersonBL.DoesPersonExistByNationalNo(txtNationalNo.Text) &&
                !(_Mode == enMode.Update && _Person.NationalNo == txtNationalNo.Text.Trim()))
            {
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "This National Number Already Exist");
                return;
            }

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.DateOfBirth = dtDateOfBirth.Value;
            _Person.Address = txtAddress.Text;
            _Person.NationalityCountryID = cbCountries.SelectedIndex + 1;
            _Person.NationalNo = txtNationalNo.Text;
            if (rdMale.Checked)
                _Person.Gendor = 0;
            else if (rdFemale.Checked) _Person.Gendor = 1;
            var ImagePath = _ChangeNameAndMoveImageToAnotherFile();
            if (ImagePath != "") _Person.ImagePath = ImagePath;


            if (_Person.Save())
            {
                DataBack?.Invoke(this, (int)_Person.PersonID);
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

            _Mode = enMode.Update;
            Close();
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "Please enter first name.");
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtSecondName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSecondName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                txtSecondName.Focus();
                errorProvider1.SetError(txtSecondName, "Please enter first name.");
            }
            else
            {
                errorProvider1.SetError(txtSecondName, "");
            }
        }

        private void txtThirdName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
            {
                txtThirdName.Focus();
                errorProvider1.SetError(txtThirdName, "Please enter first name.");
            }
            else
            {
                errorProvider1.SetError(txtThirdName, "");
            }
        }

        private void txtNationalNo_Validated(object sender, EventArgs e)
        {
            if (PersonBL.DoesPersonExistByNationalNo(txtNationalNo.Text))
            {
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "This National Number Already Exist");
            }
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.Text = new string(txtPhone.Text.Where(char.IsDigit).ToArray());
            txtPhone.SelectionStart = txtPhone.Text.Length;
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, pattern))
            {
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Please Enter A Valid Email.");
            }
        }
    }
}
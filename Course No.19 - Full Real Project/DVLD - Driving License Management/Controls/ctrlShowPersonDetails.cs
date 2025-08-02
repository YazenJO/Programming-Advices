using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD___Driving_License_Management.Properties;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ctrlShowPersonDetails : UserControl
    {
        private PersonBL _Person;
        private int _PersonID;

        public ctrlShowPersonDetails()
        {
            InitializeComponent();
        }

        private void _FillData()
        {
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " +
                           _Person.LastName;
            lblNationalNo.Text = _Person.NationalNo;
            lblDateOfBrith.Text = _Person.DateOfBirth.ToShortDateString();
            if (_Person.Gendor == 0)
            {
                lblGender.Text = "Male";
                picGender.Image = Resources.Man_32;
            }
            else
            {
                lblGender.Text = "Female";
                picGender.Image = Resources.Woman_32;
            }


            lblAddress.Text = _Person.Address;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblCountry.Text = CountryBL.Find(_Person.NationalityCountryID).CountryName;
            if (_Person.ImagePath != "") picPerson.Image = Image.FromFile(_Person.ImagePath);
        }

        public void LoadPersonDetails(int PersonID)
        {
            _PersonID = PersonID;
            _Person = PersonBL.Find(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Invalid Person !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillData();
        }

        private void ctrlShowPersonDetails_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addEditPersonScreen = new AddEdit_Person_Info(_PersonID);
            addEditPersonScreen.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
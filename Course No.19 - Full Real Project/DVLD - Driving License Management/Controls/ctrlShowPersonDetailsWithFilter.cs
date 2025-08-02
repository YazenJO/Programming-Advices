using System;
using System.Linq;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ctrlShowPersonDetailsWithFilter : UserControl
    {
        private PersonBL _person;

        public ctrlShowPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            var handler = OnPersonSelected;
            if (handler != null) handler(PersonID); // Raise the event with the parameter
        }

        private void cbUserFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAccountNSearch.Clear();
        }

        private void _EnterJustADigits()
        {
            txtAccountNSearch.Text = new string(txtAccountNSearch.Text.Where(char.IsDigit).ToArray());
            txtAccountNSearch.SelectionStart = txtAccountNSearch.Text.Length;
        }

        private void txtAccountNSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cbUserFilterBy.SelectedIndex)
            {
                case 0:
                case 1:
                    _EnterJustADigits();
                    break;
            }
        }

        private void _DisableControls()
        {
            txtAccountNSearch.Enabled = false;
            cbUserFilterBy.Enabled = false;
            btnAddNewPerson.Enabled = false;
            btnSearchPerson.Enabled = false;
        }

        public void LoadPersonDetails(int PersonID)
        {
            if (PersonBL.Find(PersonID) == null)
            {
                MessageBox.Show("Invalid Person ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtAccountNSearch.Text = PersonID.ToString();
            ctrlShowPersonDetails1.LoadPersonDetails(PersonID);
            _DisableControls();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            switch (cbUserFilterBy.SelectedIndex)
            {
                case 0:
                    _person = PersonBL.Find(int.Parse(txtAccountNSearch.Text));
                    ctrlShowPersonDetails1.LoadPersonDetails((int)_person.PersonID);
                    break;
                case 1:
                    _person = PersonBL.Find(txtAccountNSearch.Text.Trim());
                    ctrlShowPersonDetails1.LoadPersonDetails((int)_person.PersonID);
                    break;
            }

            if (OnPersonSelected != null)
                OnPersonSelected((int)_person.PersonID);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var addEditPersoninfo = new AddEdit_Person_Info(-1);
            addEditPersoninfo.DataBack += addEditPersoninfo_DataBack;
            addEditPersoninfo.ShowDialog();
        }

        private void addEditPersoninfo_DataBack(object sender, int PersonID)
        {
            txtAccountNSearch.Text = PersonID.ToString();
            ctrlShowPersonDetails1.LoadPersonDetails(PersonID);
        }

        private void ctrlShowPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            cbUserFilterBy.SelectedIndex = 0;
        }
    }
}
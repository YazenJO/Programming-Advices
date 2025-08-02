using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ManagePeopleScreen : Form
    {
        public enum enFilterBy
        {
            None,
            PersonID,
            NationalNo,
            FirstName,
            SecondName,
            ThirdName,
            LastName,
            Nationality,
            Gender,
            Phone,
            Email
        }

        private int _MainUserID;

        public ManagePeopleScreen(int _UserId)
        {
            InitializeComponent();
            _MainUserID = _UserId;
        }

        private void AvailabilitySwitch_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void _RefeshPeopleGridVeiw()
        {
            PeopleDataGridView1.DataSource = PersonBL.GetPeopleView();
            lblNOfRecords.Text = PeopleDataGridView1.RowCount.ToString();
        }

        private void _Load()
        {
            _RefeshPeopleGridVeiw();
        }

        private void ManagePeopleScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int NoFilter = 0;
            const int SpecialFilter = 8;

            if (cbFilter.SelectedIndex == NoFilter)
            {
                _RefeshPeopleGridVeiw();
                txtFilter.Visible = false;
                grbGender.Visible = false;
            }
            else if (cbFilter.SelectedIndex == SpecialFilter)
            {
                txtFilter.Visible = false;
                grbGender.Visible = true;
            }
            else
            {
                txtFilter.Visible = true;
                grbGender.Visible = false;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            switch ((enFilterBy)cbFilter.SelectedIndex)
            {
                case enFilterBy.None:
                    _RefeshPeopleGridVeiw();
                    break;
                case enFilterBy.PersonID:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("PersonID", txtFilter.Text.Trim());
                    break;
                case enFilterBy.NationalNo:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("NationalNo", txtFilter.Text.Trim());
                    break;
                case enFilterBy.FirstName:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("FirstName", txtFilter.Text.Trim());
                    break;
                case enFilterBy.SecondName:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("SecondName", txtFilter.Text.Trim());
                    break;
                case enFilterBy.ThirdName:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("ThirdName", txtFilter.Text.Trim());
                    break;
                case enFilterBy.Nationality:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("CountryName", txtFilter.Text.Trim());
                    break;
                case enFilterBy.LastName:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("LastName", txtFilter.Text.Trim());
                    break;
                case enFilterBy.Email:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("Email", txtFilter.Text.Trim());
                    break;
                case enFilterBy.Phone:
                    PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("Phone", txtFilter.Text.Trim());
                    break;
            }
        }

        private void DtimerFrom_ValueChanged(object sender, EventArgs e)
        {
            PeopleDataGridView1.DataSource = PersonBL.GetPeopleByBirthDateDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void DttimeTo_ValueChanged(object sender, EventArgs e)
        {
            PeopleDataGridView1.DataSource = PersonBL.GetPeopleByBirthDateDate(DtimerFrom.Value, DttimeTo.Value);
        }

        private void btnAddNewBorrow_Click(object sender, EventArgs e)
        {
            var addEditPersonInfoScreen = new AddEdit_Person_Info(-1);
            addEditPersonInfoScreen.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEditPersonInfoScreen = new AddEdit_Person_Info((int)PeopleDataGridView1.CurrentRow.Cells[0].Value);
            addEditPersonInfoScreen.ShowDialog();
            _RefeshPeopleGridVeiw();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showPersonDetailsScreen =
                new ShowPersonDetailsScreen((int)PeopleDataGridView1.CurrentRow.Cells[0].Value);
            showPersonDetailsScreen.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Person", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                if (PersonBL.DeletePerson((int)PeopleDataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully");
                    _RefeshPeopleGridVeiw();
                }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Future Will Be Available Soon ");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Future Will Be Available Soon ");
        }

        private void lblNOfRecords_Click(object sender, EventArgs e)
        {
        }

        private void grbGender_Enter(object sender, EventArgs e)
        {
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFemale.Checked) PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("Gendor", "1");
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMale.Checked) PeopleDataGridView1.DataSource = PersonBL.GetFilterdPeople("Gendor", "0");
        }
    }
}
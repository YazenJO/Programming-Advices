using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class EditTestType : Form
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        private readonly enMode _Mode;

        private readonly int _TestID;
        private TestTypes _TestType;

        public EditTestType(int TestID)
        {
            InitializeComponent();
            _TestID = TestID;
            if (_TestID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void _Load()
        {
            if (_Mode == enMode.AddNew)
            {
                _TestType = new TestTypes();
                return;
            }

            _TestType = TestTypes.Find(_TestID);
            lblID.Text = _TestType.TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = _TestType.TestTypeFees.ToString();
        }

        private void EditTestType_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = txtDescription.Text;
            _TestType.TestTypeFees = Convert.ToDecimal(txtFees.Text);
            if (_TestType.Save())
                MessageBox.Show("Data Saved Successfully");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
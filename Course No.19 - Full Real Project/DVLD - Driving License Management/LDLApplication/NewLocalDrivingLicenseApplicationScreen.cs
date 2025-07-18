using System;
using System.Data;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class NewLocalDrivingLicenseApplicationScreen : Form
    {
        private readonly int _MainUserID;
        private readonly ManageApplicationsTypesBL ApplicationType = ManageApplicationsTypesBL.Find(1);
        private LicenseClassesBL _LicenseClass;
        private LocalDLApplicationBL _LocalDL;
        private ApplicationsBL _NewApplication;
        private int _PersonID;

        public NewLocalDrivingLicenseApplicationScreen(int UserId)
        {
            InitializeComponent();
            _MainUserID = UserId;
        }

        private void ctrlShowPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            var PersonID = obj;
            _PersonID = PersonID;
            ctrlShowPersonDetailsWithFilter1.LoadPersonDetails(PersonID);
        }

        private void _FillLicenseClassCb()
        {
            var dt = LicenseClassesBL.GetLicenseClasses();
            foreach (DataRow row in dt.Rows) cbLicenseClass.Items.Add($"{row["LicenseClassID"],-5} {row["ClassName"]}");
        }

        private void _Load()
        {
            _FillLicenseClassCb();
            cbLicenseClass.SelectedIndex = 0;
            lblCreatedBy.Text = UserBL.Find(_MainUserID).UserName;
            lblApplicationDate.Text = DateTime.Today.ToString();
            lblApplicationFees.Text = ApplicationType.ApplicationFees.ToString();
            _NewApplication = new ApplicationsBL();
            _LocalDL = new LocalDLApplicationBL();
        }

        private void NewLocalDrivingLicenseApplicationScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _AddNewApplicationRecords()
        {
            _NewApplication.ApplicantPersonID = _PersonID;
            _NewApplication.ApplicationDate = DateTime.Now;
            _NewApplication.ApplicationStatus = 1; //Add New 
            _NewApplication.ApplicationTypeID = (int)ApplicationType.ApplicationTypeID;
            _NewApplication.CreatedByUserID = _MainUserID;
            _NewApplication.LastStatusDate = DateTime.Now;
            _NewApplication.PaidFees = ApplicationType.ApplicationFees + _LicenseClass.ClassFees;
        }

        private void _FillDataInApplicationInfo()
        {
            lblDLApplicationID.Text = _NewApplication.ApplicationID.ToString();


            lblApplicationFees.Text = ApplicationType.ApplicationFees.ToString();

            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(ApplicationType.ApplicationTypeID.ToString());
        }

        private void _AddNewLocalDL()
        {
            _LocalDL.ApplicationID = (int)_NewApplication.ApplicationID;
            _LocalDL.LicenseClassID = (int)_LicenseClass.LicenseClassID;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (_PersonID == null)
            {
                MessageBox.Show("Select A Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var selectedText = cbLicenseClass.SelectedItem.ToString();
            var parts = selectedText.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (int.TryParse(parts[0], out var LicenseCID)) _LicenseClass = LicenseClassesBL.Find(LicenseCID);

            if (ApplicationsBL.HasActiveApplicationOfType(_PersonID, (int)_LicenseClass.LicenseClassID))
            {
                MessageBox.Show("Error: There is Another Active Application For Tha Same LicenseClass For This Person",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _AddNewApplicationRecords();

            if (_NewApplication.Save())
            {
                _AddNewLocalDL();
                if (_LocalDL.Save())
                {
                    MessageBox.Show(
                        $"New local license application has been added successfully! You paid {_NewApplication.PaidFees} JD.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    _FillDataInApplicationInfo();
                }
                else
                {
                    MessageBox.Show("Error: The Local DL Data Is not Saved Successfully.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
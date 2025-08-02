using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ManageTestTypesScreen : Form
    {
        private int _MainUser;

        public ManageTestTypesScreen(int mainUser)
        {
            InitializeComponent();
            _MainUser = mainUser;
        }

        private void _RefreshManageTestTypesList()
        {
            ManageTestTypesList.DataSource = TestTypes.GetTestTypes();
            lblNOfRecords.Text = ManageTestTypesList.RowCount.ToString();
        }

        private void _Load()
        {
            _RefreshManageTestTypesList();
        }

        private void ManageTestTypesScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editTestTypeScreen = new EditTestType((int)ManageTestTypesList.CurrentRow.Cells[0].Value);
            editTestTypeScreen.ShowDialog();
            _RefreshManageTestTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
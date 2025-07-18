using System;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class ManageApplicationTypesScreen : Form
    {
        private int _MainUser;

        public ManageApplicationTypesScreen(int user)
        {
            InitializeComponent();
            _MainUser = user;
        }

        private void _RefreshManageApplicationTypesList()
        {
            ManageApplicationTypesList.DataSource = ManageApplicationsTypesBL.GetApplicationTypes();
            lblNOfRecords.Text = ManageApplicationTypesList.RowCount.ToString();
        }

        private void _Load()
        {
            _RefreshManageApplicationTypesList();
        }

        private void ManageApplicationTypesScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editApplicationsType =
                new EditApplicationsTypeSceen((int)ManageApplicationTypesList.CurrentRow.Cells[0].Value);

            editApplicationsType.ShowDialog();
            _RefreshManageApplicationTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
using System;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management
{
    public partial class ShowPersonDetailsScreen : Form
    {
        private readonly int _PersonID;

        public ShowPersonDetailsScreen(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void ShowPersonDetailsScreen_Load(object sender, EventArgs e)
        {
            ctrlShowPersonDetails1.LoadPersonDetails(_PersonID);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
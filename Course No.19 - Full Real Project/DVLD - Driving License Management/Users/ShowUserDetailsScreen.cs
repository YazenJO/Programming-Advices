using System;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management
{
    public partial class ShowUserDetailsScreen : Form
    {
        private readonly int _UserID;

        public ShowUserDetailsScreen(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void ShowUserDetailsScreen_Load(object sender, EventArgs e)
        {
            ctrlShowUserDetails1.LoadUserDetails(_UserID);
        }
    }
}
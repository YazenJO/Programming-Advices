using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LibraryBusnissLayer;

namespace Test
{
    
    public partial class MainScreen : Form
    {
        private int _UserID;
        UsersBL _User;
        public MainScreen(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            
        }
         
       

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void _Load()
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _User =UsersBL.Find(_UserID);
            lblUserName.Text = _User.Name;
            lblCardNumber.Text=_User.LibraryCardNumber;
        }

       


        private void MainScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        public void Login_DataBack(object sender, int UserID)
        {
           
        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"LibrarySettings"))
            {
                MessageBox.Show("You do not have permission to manage Settings","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            SettingsScreen SettingsScreen=new SettingsScreen();
            SettingsScreen.ShowDialog();
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            Borrows BorrowScreen=new Borrows(_UserID);
            BorrowScreen.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksScreen BookScreen = new BooksScreen(_UserID);
            BookScreen.ShowDialog();
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            ReadersScreen ReadersScreen = new ReadersScreen(_UserID);
            ReadersScreen.ShowDialog();
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManagePayments"))
            {
                MessageBox.Show("You do not have permission to manage Payments","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            PaymentsScreen PaymentsScreen = new PaymentsScreen(_UserID);
            PaymentsScreen.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_UserID,"ManageUsers"))
            {
                MessageBox.Show("You do not have permission to manage Users","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            UsersScreen UsersScreen = new UsersScreen(_UserID);
            UsersScreen.ShowDialog();
        }
    }
    }

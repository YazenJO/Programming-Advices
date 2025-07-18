using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class LoginScreen : Form
    { 
        public delegate void MyDelegate(object sender,int UserID);
        public event MyDelegate DataBack;

        public LoginScreen()
        {
            InitializeComponent();
          
        }
        
         
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            toggleShowPassword.Checked=false;

        }

        private void toggleShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !toggleShowPassword.Checked;
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
              int UserID=UsersBL.Login(txtUserName.Text,txtPassword.Text);
            if ( UserID !=-1)
            {
                MainScreen mainScreen = new MainScreen(UserID);
                mainScreen.Show();
               
                

            }
            else
            {
                MessageBox.Show("Login failed! Please check your username and password.","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          ;
          
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                UsersBL.EnableRememberMe(txtUserName.Text, txtPassword.Text);

            }
            else
            {
                UsersBL.DiableRememberMe(txtUserName.Text, txtPassword.Text);
            }
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_Enter(object sender, EventArgs e)
        {
            BtnLogin_Click_1(sender,e);
        }
    }
}
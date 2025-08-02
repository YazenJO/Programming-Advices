using System;
using System.IO;
using System.Windows.Forms;
using DVLD_BusnissLayer;

namespace DVLD___Driving_License_Management
{
    public partial class LoginScreen : Form
    {
        private int UserId;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void _GetRemeberMeContant()
        {
            var path = "UserData.txt";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(content))
                {
                    var parts = content.Split(new[] { "###" }, StringSplitOptions.None);
                    txtUserName.Text = parts[0];
                    txtPassword.Text = parts[1];
                    chkboxRememberMe.Checked = true;
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var CheckUser = UserBL.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (CheckUser != -1)
            {
                UserId = CheckUser;
                var mainScreen = new MainScreen(UserId);
                mainScreen.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password", "Login Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            var path = "UserData.txt";
            if (chkboxRememberMe.Checked)
            {
                var content = txtUserName.Text + "###" + txtPassword.Text;

                // Write the content to the file
                File.WriteAllText(path, content);
            }
            else
            {
                File.WriteAllText(path, string.Empty);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            _GetRemeberMeContant();
        }
    }
}
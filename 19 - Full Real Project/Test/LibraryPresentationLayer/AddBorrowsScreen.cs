using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Windows.Forms;
using LibraryBusnissLayer;
using LibraryBusnissLayer.Properties;

namespace Test
{
    public partial class AddBorrowsScreen : Form
    {
        
        private int _MainUserID;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private UsersBL _User;
        private BooksBL _Book;
        private int _UserID;
        
        public AddBorrowsScreen(int UserId,int MainUserID)
        {
            InitializeComponent();
            _UserID = UserId;
            _MainUserID=MainUserID;

            if (_UserID==-1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

                
            
        }

        private void _Load()
        {
            lblBorrowDate.Text=DateTime.Now.ToString();
            cbFilterBy.SelectedIndex = 0;
            cbUserFilterBy.SelectedIndex = 0;
            _FillUserComboBox();
            _FillBookComboBox();
            if (_Mode==enMode.AddNew)
            {
                _User= new UsersBL();
                return;

            }

           

        }
        private void AddBorrowsScreen_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (cbUserFilterBy.SelectedIndex==0)
            {
                _User=UsersBL.FindBYLibraryCardNumber((txtAccountNSearch.Text));
            }
            else if (cbUserFilterBy.SelectedIndex==1)
            {
                int UserID = 0;
                string BookName = default;
                string selectedText = cbUserSelect.SelectedItem.ToString();


                string[] parts = selectedText.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(parts[0], out int bookID))
                {
                    UserID=bookID;
                    _User = UsersBL.Find(UserID);
                }

                
            }
          

           
            if (_User != null)
            {
 
                lblFirstName.Text = _User.Name;
                lblAccountNumber.Text = _User.LibraryCardNumber;
                lblGender.Text = _User.Gender;
                lblDateOfBrith.Text = _User.DateOfBrith.ToString();
                lblAdress.Text = _User.Address;
                lblFacebook.Text = _User.Facebook;
                lblMobile.Text = _User.Mobile;
                lblContactInformatino.Text = _User.ContactInformation;
                picUser.Image = Image.FromFile(_User.ImageLocation);
                lblEmail.Text = _User.Email;
                

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddABorrowTab.SelectedIndex = 1;
        }

       
        private void _FillUserComboBox()
        {
            DataTable dt = UsersBL.GetUsers();
            foreach (DataRow row in dt.Rows)
            {
                cbUserSelect.Items.Add($"{row["UserID"],-10} {row["Name"]}");
                
            }
            
        }
        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            
            
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex==0)
            {
                string text = txtBookSearch.Text.Trim();
                _Book = BooksBL.GetBookByName(text);
            }
            else if(cbFilterBy.SelectedIndex==1)
            {
                int BookID = 0;
                string BookName = default;
                string selectedText = cbSelectBook.SelectedItem.ToString();


                string[] parts = selectedText.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(parts[0], out int bookID))
                {
                    BookID=bookID;
                    _Book = BooksBL.Find(BookID);
                }
               
            }

           
            int NumberOFCopies = 0;
            NumberOFCopies=BookCopiesBL.GetNumberOFAvailableCopyOfBook(_Book.BookID);
            if (_Book != null)
            {
                lblBookTitle.Text = _Book.Title;
                lblAuthoname.Text = _Book.Authorname;
                lblAdress.Text = _Book.Genre;
                lblPublication.Text = _Book.PublicationDate.ToString();
                lblISBN.Text = _Book.ISBN;
                if (NumberOFCopies>-1)
                {
                    lblNumberOFAvailableCopies.Text=NumberOFCopies.ToString();
                }
                else
                {
                    lblNumberOFAvailableCopies.Text="Error Cant Fined Number of Available Copies";
                }
                lblCopies.Text = _Book.Copies.ToString();
                lblLanguage.Text = _Book.Language;
                txtboxDescription.Text = _Book.AdditionalDetails;
                lblGenre.Text = _Book.Genre.ToString();

                
            }
            else
            {
                MessageBox.Show("Faild");
            }

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close ?","Close",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();   
            }

          
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (_User != null && _Book != null)
            {
               
                BorrowsBL borrow = new BorrowsBL();
                borrow.UserID = _User.UserID;
                borrow.CopyID = BookCopiesBL.GetAvailableCopyOFTheBook(_Book.BookID);
                if ( borrow.CopyID==-1)
                {
                    MessageBox.Show("No available copies");
                    return;
    
                }
                borrow.BorrowingDate = DateTime.Now;
                borrow.DueDate =borrow.BorrowingDate.AddDays(SettingsBL.GetDefualtBorrrowDays()) ;

                if (borrow.Save())
                {
                    MessageBox.Show("Borrowed Successfully");
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Failed to borrow book");
                }
            
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Please select user and book ᓚᘏᗢ");
            }
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_MainUserID,"ManageBooks"))
            {
                MessageBox.Show("Access Denied", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddBookScreen BookScreen = new AddBookScreen(-1,_MainUserID);
            BookScreen.ShowDialog();
            
        }

        private void _FillBookComboBox()
        {
            DataTable dt = BooksBL.GetAllBooks();
            foreach (DataRow row in dt.Rows)
            {
                cbSelectBook.Items.Add($"{row["BookID"],-10} {row["Title"],-20} {row["Genre"]}");
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Book != null)
            {
             
                    if (!UsersBL.ChckAccessPermission(_MainUserID,"ManageBooks"))
                    {
                        MessageBox.Show("You do not have permission to manage books","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                AddBookScreen BookScreen = new AddBookScreen(_Book.BookID,_MainUserID);
                BookScreen.ShowDialog();
                return;
            }
            MessageBox.Show("Please Select book" );
            
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                lblFilterByBookstate.Text = "Book Name :";
                txtBookSearch.Visible = true;
                cbSelectBook.Visible = false;
                return;
            }
            else
            {
                lblFilterByBookstate.Text = "Select Book :";
                txtBookSearch.Visible = false;
                cbSelectBook.Visible = true;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!UsersBL.ChckAccessPermission(_MainUserID,"ManageUsers"))
            {
                MessageBox.Show("You do not have permission to manage Users","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            AddEditShowUserInfo NewUserScreen = new AddEditShowUserInfo(-1);
            NewUserScreen.ShowDialog();
        }

        private void cbUserFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserFilterBy.SelectedIndex == 0)
            {
                lblFilteByState.Text = "Account Number :";
                txtAccountNSearch.Visible = true;
                cbUserSelect.Visible=false;
            }
            else
            {
                lblFilteByState.Text = "Select  User :";
                txtAccountNSearch.Visible=false;
                cbUserSelect.Visible=true;
            }
        }

        private void txtAccountNSearch_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
using System;
using System.Windows.Forms;
using LibraryBusnissLayer;

namespace Test
{
    public partial class AddBookScreen : Form
    {
      
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private UsersBL _User;
        private BooksBL _Book;
        private int _BookID;
        public AddBookScreen(int BookId,int _MainUserID)
        {
         
            InitializeComponent();
            _BookID = BookId;

            if (_BookID==-1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }

        private void _LoadData()
        {
            if (_Mode==enMode.AddNew)
            {
                SelectBookTab.Text = "Add New Book Tab";
                _Book = new BooksBL();
                return;
            }

            _Book = BooksBL.Find(_BookID);
            if (_Book==null)
            {
                MessageBox.Show("This form will be closed because No Book with ID = " + _BookID);
                this.Close();

                return;
            }

            txtBookTitle.Text = _Book.Title;
            txtISBN.Text = _Book.ISBN;
            txtGenre.Text = _Book.Genre;
            txtAuthorname.Text = _Book.Authorname;
            txtPublicationDate.Text = _Book.PublicationDate.ToString();
            txtLanguage.Text = _Book.Language;
            txtCopies.Text = _Book.Copies.ToString();
            txtboxDescription.Text = _Book.AdditionalDetails;

        }

        private void AddBookScreen_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            _Book.Title = txtBookTitle.Text;

            _Book.ISBN = txtISBN.Text;

            _Book.Genre = txtGenre.Text;

            _Book.Authorname = txtAuthorname.Text;

            _Book.PublicationDate = DateTime.Parse(txtPublicationDate.Text);
            _Book.Language = txtLanguage.Text;
            _Book.Copies = int.Parse(txtCopies.Text);
            _Book.AdditionalDetails = txtboxDescription.Text;

            if (_Book.Save())
                MessageBox.Show("Data Saved Successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                MessageBox.Show("Error: Data Is not Saved Successfully.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            _Mode = enMode.Update;
            SelectBookTab.Text = "Edit Book Tab";
            this.Close();
            
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

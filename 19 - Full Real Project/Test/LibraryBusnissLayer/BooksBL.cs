using System;
using System.Data;
using System.Runtime.CompilerServices;
using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer
{
    public class BooksBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };


        public enMode Mode = enMode.AddNew;
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; }
        public string AdditionalDetails { get; set; }
        public string Authorname { get; set; }
        public string Language { get; set; }
        public int Copies { get; set; }

        public BooksBL()
        {
            this.BookID = default;
            this.Title = default;
            this.ISBN = default;
            this.PublicationDate = default;
            this.Genre = default;
            this.AdditionalDetails = default;
            this.Authorname = default;
            this.Language = default;
            this.Copies = default;

            Mode = enMode.AddNew;
        }

        private BooksBL(int BookID, string Title, string ISBN, DateTime PublicationDate, string Genre,
            string AdditionalDetails, string Authorname, string Language, int Copies)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            this.Genre = Genre;
            this.AdditionalDetails = AdditionalDetails;
            this.Authorname = Authorname;
            this.Language = Language;
            this.Copies = Copies;

            Mode = enMode.Update;
        }

        private bool _AddNewBooks()
        {
            // Call Data Access Layer 
            this.BookID = BooksData.AddNewBook(this.Title, this.ISBN, this.PublicationDate, this.Genre,
                this.AdditionalDetails, this.Authorname,
                this.Language, this.Copies);

            return (this.BookID != -1);
        }

        private bool _UpdateBooks()
        {
            // Call Data Access Layer 
            return BooksData.UpdateBook(this.BookID, this.Title, this.ISBN, this.PublicationDate,
                this.Genre, this.AdditionalDetails, this.Authorname, this.Language, this.Copies);
        }

        public static BooksBL Find(int BookID)
        {
            string Title = default;
            string ISBN = default;
            DateTime PublicationDate = default;
            string Genre = default;
            string AdditionalDetails = default;
            string Authorname = default;
            string Language = default;
            int Copies = default;

            if (BooksData.GetBookInfoByID(BookID, ref Title, ref ISBN, ref PublicationDate, ref Genre,
                    ref AdditionalDetails, ref Authorname,
                    ref Language, ref Copies))
            {
                return new BooksBL(BookID, Title, ISBN, PublicationDate, Genre, AdditionalDetails, Authorname, Language,
                    Copies);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBooks())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBooks();
            }

            return false;
        }




        public static DataTable GetAllBooks()
        {
            return BooksData.GetAllBooks();
        }

        public static bool DeleteBooks(int BookID)
        {
            return BooksData.DeleteBook(BookID);
        }

        public static bool isBooksExist(int BookID)
        {
            return BooksData.IsBookExist(BookID);
        }

        public static DataTable GetFilterdBooks(string FilterName, string Value)
        {
            return BooksData.GetFilterdBooks(FilterName, Value);
        }
        

        public static BooksBL 
            GetBookByName(string Name)
        {
            int BookID = default;
            DateTime PublishedDate = default;
            string Genre = default;
            string ISBN = default;
            string AdditionalDetails = default;
            string Authorname = default;
            string Language = default;
            int Copies = default;

            bool isFound = BooksData.GetBookInfoByName(Name, ref BookID, ref ISBN, ref PublishedDate, ref Genre,
                ref AdditionalDetails, ref Authorname, ref Language
                , ref Copies);
            if (isFound)
            {
                return new BooksBL(BookID, Name, ISBN, PublishedDate, Genre, AdditionalDetails, Authorname, Language
                    , Copies);
            }

            return null;





        }
        
        public static DataTable GetdBookLanguage(string Language)
        {
            return BooksData.GetBookByLanguage(Language);
        }
        
        public static DataTable GetBooksByPublishDateDate(DateTime fromDate,DateTime ToDate)
        =>BooksData.GetBooksByPublishDateDate(fromDate,ToDate);
    }
}


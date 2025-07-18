using System.Data;
using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer.Properties
{
    public class BookCopiesBL
    {


        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        public enMode Mode = enMode.AddNew;
        public int CopyID { set; get; }
        public int BookID { set; get; }
        public bool AvailabilityStatus { set; get; }

        public BookCopiesBL()
        {
            this.CopyID = -1;
            this.BookID = -1;
            this.AvailabilityStatus = false;
            Mode = enMode.AddNew;
        }

        private BookCopiesBL(int CopyID, int BookID, bool AvailabilityStatus)
        {
            this.CopyID = CopyID;
            this.BookID = BookID;
            this.AvailabilityStatus = AvailabilityStatus;
            Mode = enMode.Update;
        }

        private bool _AddNewCopy()
        {
            this.CopyID = (int)BookCopiesDAO.AddNewCopy(this.BookID, this.AvailabilityStatus);
            return (this.CopyID != -1);
        }

        private bool _UpdateCopy()
            => BookCopiesDAO.UpdateCopy(this.CopyID, this.BookID, this.AvailabilityStatus);

        public static BookCopiesBL Find(int CopyID)
        {
            int BookID = -1;
            bool AvailabilityStatus = false;

            bool IsFound = BookCopiesDAO.GetCopyByID(CopyID, ref BookID, ref AvailabilityStatus);

            if (IsFound)
                return new BookCopiesBL(CopyID, BookID, AvailabilityStatus);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCopy())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCopy();
            }

            return false;
        }

        public static bool DeleteCopy(int CopyID)
            => BookCopiesDAO.DeleteCopy(CopyID);

        public static bool DoesCopyExist(int CopyID)
            => BookCopiesDAO.DoesCopyExist(CopyID);

        public static DataTable GetBookCopies()
            => BookCopiesDAO.GetAllBookCopies();


        public static int GetAvailableCopyOFTheBook(int BookID)
        {
            return BookCopiesDAO.GetAvailableCopyOFTheBook(BookID);
        }

        public static int GetNumberOFAvailableCopyOfBook(int BookID)
        {
            int NumberOfCopies = 0;
            if (BookCopiesDAO.GetNumberOFAvailableCopyOfBook(BookID,ref NumberOfCopies))
            {
                return NumberOfCopies;
            }

            return -1;
        }
        
        public static bool MarkCopyIDAsAvailable(int CopyID)
            => BookCopiesDAO.MarkCopyIDAsAvailabil(CopyID);
        
        public static bool MarkCopyIDAsNotAvailable(int CopyID)
            => BookCopiesDAO.MarkCopyIDAsNotAvailabil(CopyID);

        public static bool MarkCopyAsAvailableByBorrowId(int BorrowID)
            => BookCopiesDAO.MarkCopyAsAvailabilByBorrowID(BorrowID);
        
        public static DataTable GetAvailableCopies()
            => BookCopiesDAO.GetAvailabilCopies();
        
        public static DataTable GetNotAvailableCopies()
            => BookCopiesDAO.GetNotAvailabilCopies();
        
        public static bool IsCopyAvailable(int CopyID)
        => BookCopiesDAO.IsCopyAvailable(CopyID);
        
    }
}

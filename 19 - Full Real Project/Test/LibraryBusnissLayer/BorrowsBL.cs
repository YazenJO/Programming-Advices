using System;
using System.Data;
using System.Data.SqlClient;
using LibraryBusnissLayer.Properties;
using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer
{
    public class BorrowsBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        public enMode Mode = enMode.AddNew;
        public int BorrowingRecordID { set; get; }
        public int UserID { set; get; }
        public int CopyID { set; get; }
        public DateTime BorrowingDate { set; get; }
        public DateTime DueDate { set; get; }
        public DateTime? ActualReturnDate { set; get; }

        public BorrowsBL()
        {
            this.BorrowingRecordID = default;
            this.UserID = -1;
            this.CopyID = -1;
            this.BorrowingDate = DateTime.Now;
            this.DueDate = DateTime.Now;
            this.ActualReturnDate = null;
            Mode = enMode.AddNew;
        }

        private BorrowsBL(int BorrowingRecordID, int UserID, int CopyID, DateTime BorrowingDate, DateTime DueDate,
            DateTime? ActualReturnDate)
        {
            this.BorrowingRecordID = BorrowingRecordID;
            this.UserID = UserID;
            this.CopyID = CopyID;
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
            Mode = enMode.Update;
        }

        private bool _AddNewBorrowingRecord()
        {
            bool ResultOFMark = false;
            this.BorrowingRecordID = (int)BorrowingRecordDAO.AddNewBorrowingRecord(this.UserID, this.CopyID,
                this.BorrowingDate, this.DueDate, this.ActualReturnDate);
            ResultOFMark = BookCopiesBL.MarkCopyIDAsNotAvailable(this.CopyID);
            return (this.BorrowingRecordID != -1 && ResultOFMark);
        }

        private bool _UpdateBorrowingRecord()
            => BorrowingRecordDAO.UpdateBorrowingRecord(this.BorrowingRecordID, this.UserID, this.CopyID,
                this.BorrowingDate, this.DueDate, this.ActualReturnDate);

        public static BorrowsBL Find(int BorrowingRecordID)
        {
            int UserID = -1;
            int CopyID = -1;
            DateTime BorrowingDate = DateTime.Now;
            DateTime DueDate = DateTime.Now;
            DateTime? ActualReturnDate = null;

            bool IsFound = BorrowingRecordDAO.GetBorrowingRecordById(BorrowingRecordID, ref UserID, ref CopyID,
                ref BorrowingDate, ref DueDate, ref ActualReturnDate);

            if (IsFound)
                return new BorrowsBL(BorrowingRecordID, UserID, CopyID, BorrowingDate, DueDate, ActualReturnDate);
            else
                return null;
        }
        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrowingRecord())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBorrowingRecord();
            }

            return false;
        }

        public static bool DoesUserHaveBorrowingRecord(int UserID)
            => BorrowingRecordDAO.DoesUserHaveBorrowingRecord(UserID);
        public static bool DeleteBorrowingRecord(int BorrowingRecordID)
            => BorrowingRecordDAO.DeleteBorrowingRecord(BorrowingRecordID);

        public static bool DoesBorrowingRecordExist(int BorrowingRecordID)
            => BorrowingRecordDAO.CheckIfBookIsBorrowed(BorrowingRecordID);

        public static DataTable GetBorrowingRecords()
            => BorrowingRecordDAO.GetAllBorrowingRecords();

        public static DataTable GetBorrowingRecordsByUserId(int UserID)
            => BorrowingRecordDAO.GetBorrowingRecordsByUserId(UserID);

        public static DataTable GetBorrowingRecordsByCopyId(int CopyID)
            => BorrowingRecordDAO.GetBorrowingRecordsByCopyId(CopyID);

        public static DataTable GetBorrowingRecordsByDate(DateTime fromDate, DateTime toDate)
            => BorrowingRecordDAO.GetBorrowingRecordsByDate(fromDate, toDate);

        public static DataTable GetOverdueBorrowingRecords()
            => BorrowingRecordDAO.GetOverdueBorrowingRecords();

        public static DataTable GetOnTimeBorrowingRecords()
            => BorrowingRecordDAO.GetOnTimeBorrowingRecords();

        public static bool ReturnBook(int borrowingRecordID, ref FinesBl finee)
        {
            int copyID = GetCopyIDByBorrowId(borrowingRecordID);
            if (copyID == -1 || BookCopiesBL.IsCopyAvailable(copyID))
                return false;

            if (!BorrowingRecordDAO.ReturnBook(borrowingRecordID))
                return false;

            decimal fineAmount = FinesBl.CalculateFineForABorrow(borrowingRecordID);
            if (fineAmount >= 0)
            {
                finee = new FinesBl
                {
                    UserID = GetUserIdByBorrowId(borrowingRecordID),
                    BorrowingRecordID = borrowingRecordID,
                    NumberOfLateDays = CalculateLateDayes(borrowingRecordID),
                    FineAmount = fineAmount
                };

                if (!finee.Save())
                    return false;
            }

            return BookCopiesBL.MarkCopyAsAvailableByBorrowId(borrowingRecordID);

        }

        public static int GetUserIdByBorrowId(int borrowId)
            => BorrowingRecordDAO.GetUserIdByBorrowId(borrowId);

        public static int GetCopyIDByBorrowId(int borrowId)
            => BorrowingRecordDAO.GetCopyIDByBorrowId(borrowId);

        public static int CalculateBorrowDays(int BorrowingRecordID)
        {
            return (BorrowingRecordDAO.CalculateBorrowDays(BorrowingRecordID));
        }

        public static int CalculateLateDayes(int BorrowId)
        {
            int NumberOFDays = CalculateBorrowDays(BorrowId);
            int DefaultBorrowDays = SettingsBL.GetDefualtBorrrowDays();
            int NumberOfLateDays = NumberOFDays - DefaultBorrowDays;
            return (NumberOfLateDays <= 0 ? 0 : NumberOfLateDays);
        }

        public bool ExtendBorrowDays()
            => BorrowingRecordDAO.ExtentdBorrow(this.BorrowingRecordID, SettingsBL.GetExtendedBorrowDays());

        public class BorrowingViewBL
        {
            public enum enMode
            {
                ShowMode = 0,
                Edit = 1
            };

            public enMode Mode=enMode.ShowMode;
            public int BorrowingRecordID { get; set; }
            public string UserName { get; set; }
            public string BookTitle { get; set; }
            public string Genre { get; set; }
            public string BookISBN { get; set; }
            public DateTime BorrowingDate { get; set; }
            public DateTime DueDate { get; set; }
            public DateTime? ActualReturnDate { get; set; }
            public bool AvailabilityStatus { get; set; }
            public bool? PaymentStatus { get; set; }

            private BorrowingViewBL(int BorrowingRecordID, string UserName,
                string BookTitle, string Genre, string BookISBN,
                DateTime BorrowingDate, DateTime DueDate, DateTime? ActualReturnDate,
                bool AvailabilityStatus, bool? PaymentStatus)
            {
                this.BorrowingRecordID = BorrowingRecordID;
                this.UserName = UserName;
                this.BookTitle = BookTitle;
                this.Genre = Genre;
                this.BookISBN = BookISBN;
                this.BorrowingDate = BorrowingDate;
                this.DueDate = DueDate;
                this.ActualReturnDate = ActualReturnDate;
                this.AvailabilityStatus = AvailabilityStatus;
                this.PaymentStatus = PaymentStatus;
            }

            public static BorrowingViewBL Find(int BorrowingRecordID)
            {
                string UserName = default;
                string BookTitle = default;
                string Genre = default;
                string BookISBN = default;
                DateTime BorrowingDate = DateTime.Now;
                DateTime DueDate = DateTime.Now;
                DateTime? ActualReturnDate = null;
                bool AvailabilityStatus = default;
                bool? PaymentStatus = default;



                bool IsFound = BorrowingRecordDAO.BorrowViewDAO.GetBorrowingViewRecordById(BorrowingRecordID,
                    ref UserName, ref BookTitle, ref Genre, ref BookISBN, ref BorrowingDate, ref DueDate,
                    ref ActualReturnDate, ref AvailabilityStatus, ref PaymentStatus);

                if (IsFound)
                    return new BorrowingViewBL(BorrowingRecordID, UserName, BookTitle, Genre, BookISBN, BorrowingDate,
                        DueDate, ActualReturnDate, AvailabilityStatus, PaymentStatus);
                else
                    return null;


            }

            private bool _UpdateBorrowingViewRecord()
                => BorrowingRecordDAO.BorrowViewDAO.UpdateBorrowningRecord(this.BorrowingRecordID, this.UserName,
                    this.BookTitle, this.Genre, this.BookISBN, this.BorrowingDate, this.DueDate, this.ActualReturnDate,
                    this.AvailabilityStatus, this.PaymentStatus);

            

            public bool Save()
            {
                switch (Mode)
                {
                    case enMode.ShowMode:
                        return false;

                    case enMode.Edit:
                        return _UpdateBorrowingViewRecord();

                }

                return false;
            }

        }



    }
}

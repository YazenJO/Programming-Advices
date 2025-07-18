using System.Data;
using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer
{
    public class FinesBl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int FineID { set; get; }
        public int UserID { set; get; }
        public int BorrowingRecordID { set; get; }
        public int NumberOfLateDays { set; get; }
        public decimal FineAmount { set; get; }
        public bool PaymentStatus { set; get; }

        public FinesBl()
        {
            this.FineID = -1;
            this.UserID = -1;
            this.BorrowingRecordID = -1;
            this.NumberOfLateDays = -1;
            this.FineAmount = -1;
            this.PaymentStatus = false;
            Mode = enMode.AddNew;
        }
        private FinesBl(int FineID, int UserID, int BorrowingRecordID, int NumberOfLateDays, decimal FineAmount, bool PaymentStatus)
        {
            this.FineID = FineID;
            this.UserID = UserID;
            this.BorrowingRecordID = BorrowingRecordID;
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.PaymentStatus = PaymentStatus;
            Mode = enMode.Update;
        }
        private bool _AddNewFine()
        {
            this.FineID = (int)FinesDAO.AddNewFine(this.UserID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount, this.PaymentStatus);
            return (this.FineID != -1);
        }
        private bool _UpdateFine()
            => FinesDAO.UpdateFine(this.FineID, this.UserID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount, this.PaymentStatus);
        public static FinesBl Find(int FineID)
        {
            int UserID = -1;
            int BorrowingRecordID = -1;
            int NumberOfLateDays = -1;
            decimal FineAmount = -1;
            bool PaymentStatus = false;

            bool IsFound = FinesDAO.GetFineInfoByID(FineID, ref UserID, ref BorrowingRecordID,ref NumberOfLateDays, ref FineAmount, ref PaymentStatus);

            if(IsFound)
                return new FinesBl(FineID, UserID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus);
            else
                return null;
        }
        public static FinesBl FindByBorrowId(int BorrowID)
        {
            int UserID = -1;
            int FineID = -1;
            int NumberOfLateDays = -1;
            decimal FineAmount = -1;
            bool PaymentStatus = false;

            bool IsFound = FinesDAO.GetFineInfoByBorrowID(BorrowID, ref UserID, ref FineID,ref NumberOfLateDays, ref FineAmount, ref PaymentStatus);

            if(IsFound)
                return new FinesBl(FineID, UserID, BorrowID, NumberOfLateDays, FineAmount, PaymentStatus);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewFine())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateFine();
            }
            return false;
        }
        public static bool DeleteFine(int FineID)
            => FinesDAO.DeleteFine(FineID);
        public static bool DoesFineExist(int FineID)
            => FinesDAO.IsFineExist(FineID);
        public static DataTable GetFines()
            => FinesDAO.GetAllFines();
     

        public static int CalculateFineForABorrow(int BorrowID)
        {
            int NumberOFDays = BorrowsBL.CalculateBorrowDays(BorrowID);
            int BorrowDays = SettingsBL.GetDefualtBorrrowDays();
            int FinePerDay = SettingsBL.GetDefaultFinePerDay();
            int LateFinePerDay = SettingsBL.GetLateFineByDay();
            int FineAmount = -1;
            if (NumberOFDays <=BorrowDays )
            {
                FineAmount = (NumberOFDays) * FinePerDay;
            }
            else
            {
                int LateDays = NumberOFDays - BorrowDays;
                FineAmount = ((BorrowDays) * FinePerDay) +(LateDays * LateFinePerDay) ;
            }

            
            return FineAmount;
        }
         
    }
}
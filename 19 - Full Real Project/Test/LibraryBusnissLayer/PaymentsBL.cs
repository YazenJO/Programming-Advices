using System;
using System.Data;
using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer
{
    public class PaymentsBL
    {
    
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PaymentID { set; get; }
        public int ReaderID { set; get; }
        public DateTime PaymymentDate { set; get; }
        public decimal PaymentAmount { set; get; }
        public int UserID { set; get; }

        public PaymentsBL()
        {
            this.PaymentID = -1;
            this.ReaderID = -1;
            this.PaymymentDate = DateTime.Now;
            this.PaymentAmount = -1;
            this.UserID = -1;
            Mode = enMode.AddNew;
        }
        private PaymentsBL(int PaymentID, int ReaderID, DateTime PaymymentDate, decimal PaymentAmount, int UserID)
        {
            this.PaymentID = PaymentID;
            this.ReaderID = ReaderID;
            this.PaymymentDate = PaymymentDate;
            this.PaymentAmount = PaymentAmount;
            this.UserID = UserID;
            Mode = enMode.Update;
        }
        private bool _AddNewPayment()
        {
            this.PaymentID = (int)PaymentsDAO.AddNewPayment(this.ReaderID, this.PaymymentDate, this.PaymentAmount, this.UserID);
            return (this.PaymentID != -1);
        }
        private bool _UpdatePayment()
            => PaymentsDAO.UpdatePayment(this.PaymentID, this.ReaderID, this.PaymymentDate, this.PaymentAmount, this.UserID);
        public static PaymentsBL Find(int PaymentID)
        {
            int ReaderID = -1;
            DateTime PaymymentDate = DateTime.Now;
            decimal PaymentAmount = -1;
            int UserID = -1;

            bool IsFound = PaymentsDAO.GetPaymentByID(PaymentID, ref ReaderID, ref PaymymentDate, ref PaymentAmount, ref UserID);

            if(IsFound)
                return new PaymentsBL(PaymentID, ReaderID, PaymymentDate, PaymentAmount, UserID);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePayment();
            }
            return false;
        }
        public static bool DeletePayment(int PaymentID)
            => PaymentsDAO.DeletePayment(PaymentID);
        public static bool DoesPaymentExist(int PaymentID)
            => PaymentsDAO.DoesPaymentExist(PaymentID);
        public static DataTable GetPayments()
            => PaymentsDAO.GetAllPayments();
        
        public static DataTable GetFilteredPayments(string FilterName, string Value)
            => PaymentsDAO.GetFilterdPayments(FilterName, Value);
        
        public static DataTable GetPaymentsBYBirthDate(DateTime startDate, DateTime endDate)
            => PaymentsDAO.GetPaymentsByBirthDateDate(startDate, endDate);
    }

    }

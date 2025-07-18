using System;
using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class ApplicationsBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public ApplicationsBL()
        {
            ApplicationID = null;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private ApplicationsBL(int? ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees,
            int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        public int? ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public byte ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }

        private bool _AddNewApplication()
        {
            ApplicationID = ApplicationsDAO.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return ApplicationID != -1;
        }

        private bool _UpdateApplication()
        {
            return ApplicationsDAO.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public static ApplicationsBL Find(int? ApplicationID)
        {
            var ApplicantPersonID = -1;
            var ApplicationDate = DateTime.Now;
            var ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            var LastStatusDate = DateTime.Now;
            decimal PaidFees = -1;
            var CreatedByUserID = -1;

            var IsFound = ApplicationsDAO.GetApplicationByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
                ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ApplicationsBL(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                    ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateApplication();
            }

            return false;
        }

        public static bool DeleteApplication(int? ApplicationID)
        {
            return ApplicationsDAO.DeleteApplication(ApplicationID);
        }

        public static bool DoesApplicationExist(int? ApplicationID)
        {
            return ApplicationsDAO.DoesApplicationExist(ApplicationID);
        }

        public static DataTable GetApplications()
        {
            return ApplicationsDAO.GetAllApplications();
        }

        public static bool HasActiveApplicationOfType(int PersonID, int ApplicationTypeID)
        {
            return ApplicationsDAO.HasActiveApplicationOfType(PersonID, ApplicationTypeID);
        }
    }
}
using System;
using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class LocalDLApplicationBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public LocalDLApplicationBL()
        {
            LocalDrivingLicenseApplicationID = null;
            ApplicationID = -1;
            LicenseClassID = -1;
            Mode = enMode.AddNew;
        }

        private LocalDLApplicationBL(int? LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;
        }

        public int? LocalDrivingLicenseApplicationID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID { set; get; }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID =
                LocalDLApplicationDAO.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
            return LocalDrivingLicenseApplicationID != -1;
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return LocalDLApplicationDAO.UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID,
                ApplicationID, LicenseClassID);
        }

        public static LocalDLApplicationBL Find(int? LocalDrivingLicenseApplicationID)
        {
            var ApplicationID = -1;
            var LicenseClassID = -1;

            var IsFound = LocalDLApplicationDAO.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID,
                ref ApplicationID, ref LicenseClassID);

            if (IsFound)
                return new LocalDLApplicationBL(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }

            return false;
        }

        public static bool DeleteLocalDrivingLicenseApplication(int? LocalDrivingLicenseApplicationID)
        {
            return LocalDLApplicationDAO.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }

        public static bool DoesLocalDrivingLicenseApplicationExist(int? LocalDrivingLicenseApplicationID)
        {
            return LocalDLApplicationDAO.DoesLocalDrivingLicenseApplicationExist(LocalDrivingLicenseApplicationID);
        }

        public static DataTable GetLocalDrivingLicenseApplications()
        {
            return LocalDLApplicationDAO.GetAllLocalDrivingLicenseApplications();
        }

        public static DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            return LocalDLApplicationDAO.GetAllLocalDrivingLicenseApplications_View();
        }

        public static DataTable GetFilterdLDLRecords(string FilterName, string Value)
        {
            return LocalDLApplicationDAO.GetFilterdLDLRecords(FilterName, Value);
        }

        public static DataTable GetLDLByApplicationDate(DateTime StartDate, DateTime EndDate)
        {
            return LocalDLApplicationDAO.GetLDLByApplicationDate(StartDate, EndDate);
        }
    }
}
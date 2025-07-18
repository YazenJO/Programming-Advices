using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class ManageApplicationsTypesBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public ManageApplicationsTypesBL()
        {
            ApplicationTypeID = null;
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = -1;
            Mode = enMode.AddNew;
        }

        private ManageApplicationsTypesBL(int? ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            Mode = enMode.Update;
        }

        public int? ApplicationTypeID { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        private bool _AddNewApplicationType()
        {
            ApplicationTypeID = ManageApplicationTypesDAO.AddNewApplicationType(ApplicationTypeTitle, ApplicationFees);
            return ApplicationTypeID != -1;
        }

        private bool _UpdateApplicationType()
        {
            return ManageApplicationTypesDAO.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTitle,
                ApplicationFees);
        }

        public static ManageApplicationsTypesBL Find(int? ApplicationTypeID)
        {
            var ApplicationTypeTitle = string.Empty;
            decimal ApplicationFees = -1;

            var IsFound = ManageApplicationTypesDAO.GetApplicationTypeByID(ApplicationTypeID, ref ApplicationTypeTitle,
                ref ApplicationFees);

            if (IsFound)
                return new ManageApplicationsTypesBL(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateApplicationType();
            }

            return false;
        }

        public static bool DeleteApplicationType(int? ApplicationTypeID)
        {
            return ManageApplicationTypesDAO.DeleteApplicationType(ApplicationTypeID);
        }

        public static bool DoesApplicationTypeExist(int? ApplicationTypeID)
        {
            return ManageApplicationTypesDAO.DoesApplicationTypeExist(ApplicationTypeID);
        }

        public static DataTable GetApplicationTypes()
        {
            return ManageApplicationTypesDAO.GetAllApplicationTypes();
        }
    }
}
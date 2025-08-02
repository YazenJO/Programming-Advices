using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class LicenseClassesBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public LicenseClassesBL()
        {
            LicenseClassID = null;
            ClassName = string.Empty;
            ClassDescription = string.Empty;
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = -1;
            Mode = enMode.AddNew;
        }

        private LicenseClassesBL(int? LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge,
            byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = enMode.Update;
        }

        public int? LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }

        private bool _AddNewLicenseClass()
        {
            LicenseClassID = LicenseClassesDAO.AddNewLicenseClass(ClassName, ClassDescription, MinimumAllowedAge,
                DefaultValidityLength, ClassFees);
            return LicenseClassID != -1;
        }

        private bool _UpdateLicenseClass()
        {
            return LicenseClassesDAO.UpdateLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge,
                DefaultValidityLength, ClassFees);
        }

        public static LicenseClassesBL Find(int? LicenseClassID)
        {
            var ClassName = string.Empty;
            var ClassDescription = string.Empty;
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            var IsFound = LicenseClassesDAO.GetLicenseClassByID(LicenseClassID, ref ClassName, ref ClassDescription,
                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new LicenseClassesBL(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge,
                    DefaultValidityLength, ClassFees);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateLicenseClass();
            }

            return false;
        }

        public static bool DeleteLicenseClass(int? LicenseClassID)
        {
            return LicenseClassesDAO.DeleteLicenseClass(LicenseClassID);
        }

        public static bool DoesLicenseClassExist(int? LicenseClassID)
        {
            return LicenseClassesDAO.DoesLicenseClassExist(LicenseClassID);
        }

        public static DataTable GetLicenseClasses()
        {
            return LicenseClassesDAO.GetAllLicenseClasses();
        }
    }
}
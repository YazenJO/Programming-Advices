using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class TestTypes
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public TestTypes()
        {
            TestTypeID = null;
            TestTypeTitle = string.Empty;
            TestTypeDescription = string.Empty;
            TestTypeFees = -1;
            Mode = enMode.AddNew;
        }

        private TestTypes(int? TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            Mode = enMode.Update;
        }

        public int? TestTypeID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        private bool _AddNewTestType()
        {
            TestTypeID = TestTypesDAO.AddNewTestType(TestTypeTitle, TestTypeDescription, TestTypeFees);
            return TestTypeID != -1;
        }

        private bool _UpdateTestType()
        {
            return TestTypesDAO.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }

        public static TestTypes Find(int? TestTypeID)
        {
            var TestTypeTitle = string.Empty;
            var TestTypeDescription = string.Empty;
            decimal TestTypeFees = -1;

            var IsFound = TestTypesDAO.GetTestTypeByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription,
                ref TestTypeFees);

            if (IsFound)
                return new TestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateTestType();
            }

            return false;
        }

        public static bool DeleteTestType(int? TestTypeID)
        {
            return TestTypesDAO.DeleteTestType(TestTypeID);
        }

        public static bool DoesTestTypeExist(int? TestTypeID)
        {
            return TestTypesDAO.DoesTestTypeExist(TestTypeID);
        }

        public static DataTable GetTestTypes()
        {
            return TestTypesDAO.GetAllTestTypes();
        }
    }
}
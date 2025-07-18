using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class TestBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public TestBL()
        {
            TestID = null;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = null;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private TestBL(int? TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        public int? TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        private bool _AddNewTest()
        {
            TestID = TestDAO.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return TestID != -1;
        }

        private bool _UpdateTest()
        {
            return TestDAO.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        public static TestBL Find(int? TestID)
        {
            var TestAppointmentID = -1;
            var TestResult = false;
            string Notes = null;
            var CreatedByUserID = -1;

            var IsFound = TestDAO.GetTestByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes,
                ref CreatedByUserID);

            if (IsFound)
                return new TestBL(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateTest();
            }

            return false;
        }

        public static bool DeleteTest(int? TestID)
        {
            return TestDAO.DeleteTest(TestID);
        }

        public static bool DoesTestExist(int? TestID)
        {
            return TestDAO.DoesTestExist(TestID);
        }

        public static DataTable GetTests()
        {
            return TestDAO.GetAllTests();
        }
    }
}
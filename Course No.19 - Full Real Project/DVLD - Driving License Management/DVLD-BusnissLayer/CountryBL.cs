using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class CountryBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public CountryBL()
        {
            CountryID = null;
            CountryName = string.Empty;
            Mode = enMode.AddNew;
        }

        private CountryBL(int? CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            Mode = enMode.Update;
        }

        public int? CountryID { set; get; }
        public string CountryName { set; get; }

        private bool _AddNewCountry()
        {
            CountryID = CountryDAO.AddNewCountry(CountryName);
            return CountryID != -1;
        }

        private bool _UpdateCountry()
        {
            return CountryDAO.UpdateCountry(CountryID, CountryName);
        }

        public static CountryBL Find(int? CountryID)
        {
            var CountryName = string.Empty;

            var IsFound = CountryDAO.GetCountryByID(CountryID, ref CountryName);

            if (IsFound)
                return new CountryBL(CountryID, CountryName);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateCountry();
            }

            return false;
        }

        public static bool DeleteCountry(int? CountryID)
        {
            return CountryDAO.DeleteCountry(CountryID);
        }

        public static bool DoesCountryExist(int? CountryID)
        {
            return CountryDAO.DoesCountryExist(CountryID);
        }

        public static DataTable GetCountries()
        {
            return CountryDAO.GetAllCountries();
        }
    }
}
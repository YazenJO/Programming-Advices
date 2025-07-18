using System.Data;
using ContactsDataLayer;
using ContactsDataLayer.Properties;

namespace ContactsBusnissLayar.Properties
{
    public class clsCountry
    {
        public enum enMode{AddNew=0,Update=1}
        public enMode Mode =enMode.AddNew;
        public int ID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            ID = -1;
            CountryName = "";
            Mode = enMode.AddNew;
        }

        public clsCountry(int id, string country)
        {
            this.ID = id;
            this.CountryName = country;
            Mode = enMode.Update;
        }

        public static clsCountry GetCountry(int ID)
        {
            string countryName = "";
            if (clsCountriesDataAccess.FindCountryById(ID, ref countryName))
            {
                return new clsCountry(ID, countryName);
            }
            else
            {
                return null;
            }

           
        }

        public static bool IsExist(string Country)
        {
            return clsCountriesDataAccess.IsExist(Country);
        }
        public static bool IsExist(int id)
        {
            return clsCountriesDataAccess.IsExist(id);
        }

        private bool _UpadateCountry(string Country)
        {
            return clsCountriesDataAccess.UpdateCountry(this.ID, this.CountryName);
        }

        private bool _AddNewCountry(string Country)
        {
            this. ID=clsCountriesDataAccess.AddCountry(Country);
            if (ID!=-1)
            {
                
                return true;
            }
            return false;
        }

        public static bool DeleteCountry(string Country)
        {
            return clsCountriesDataAccess.DeleteCountry(Country);
        }
        public static bool DeleteCountry(int CountryID)
        {
            return clsCountriesDataAccess.DeleteCountry(CountryID);
        }

        public static DataTable ListCountries()
        {
            return clsCountriesDataAccess.ListCountries();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry(this.CountryName))
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    

                    
                case enMode.Update:
                    return _UpadateCountry(this.CountryName);
            }

            return false;
        }
    }
}
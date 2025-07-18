using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer
{
    public class SettingsBL
    {
        
       
       

        public static int GetDefualtBorrrowDays()
        {
            int DefualtBorrrowDays = 0;
            if (SettingsDAO.DefualtBorrrowDays(ref DefualtBorrrowDays))
            {
                return DefualtBorrrowDays;
            }

            return DefualtBorrrowDays;

        }

        public static int GetDefaultFinePerDay()
        {
            int DefaultFinePerDay = 0;
            if (SettingsDAO.GetDefaultFinePerDay(ref DefaultFinePerDay))
            {
                return DefaultFinePerDay;
            }

            return DefaultFinePerDay;
        }

        public static bool UpdateDefaultFinePerDay(int NewDefaultBorrowDays)
        {
            return SettingsDAO.UpdateDefaultFinePerDay(NewDefaultBorrowDays);
        }
        
        public static bool UpdateDefaultBorrowDays(int NewDefaultFinePerDay)
        {
            return SettingsDAO.UpdateDefaultBorrowDays(NewDefaultFinePerDay);
        }
        
        
        public static int GetExtendedBorrowDays()
        {
            int ExtendedBorrowDaysV = 0;
            if (SettingsDAO.ExtendedBorrowDays(ref ExtendedBorrowDaysV))
            {
                return  ExtendedBorrowDaysV ;
            }

            return ExtendedBorrowDaysV ;

        }
        
        public static bool UpdateExtendedBorrowDays(int NewExtendedBorrowDays)
        {
            return SettingsDAO.UpdateExtendedBorrowDays(NewExtendedBorrowDays);
        }

        public static int GetLateFineByDay()
        {
            int LateFineByDay = -1;
            if (SettingsDAO.LateFineByDay(ref LateFineByDay))
            {
                return LateFineByDay;
            }

            return LateFineByDay;
        }
        
        public static bool UpdateLateFineByDay(int NewLateFineByDay)
        {
            return SettingsDAO.UpdateLateFineByDay(NewLateFineByDay);
        }

        
    }
}
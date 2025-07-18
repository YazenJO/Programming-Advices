using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer
{
    public class PermissionsBL
    {
        public static int GetPermissionValue(string permissionName)
        {
            int permissionValue = PermissionsDAO.GetPermissionsNumber(permissionName);
            if (permissionValue!=0)
            {
                return permissionValue;
            }

            return 0;
        }
        
    }
}
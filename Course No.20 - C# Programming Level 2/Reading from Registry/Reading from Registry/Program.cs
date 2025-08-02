using System;

namespace Reading_from_Registry
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
            string valueName = "YourValueName";
            try
            {
                // Attempt to read the registry value
                string value = Microsoft.Win32.Registry.GetValue(keyPath, valueName, null) as string; 
                
                if (value != null)
                {
                    Console.WriteLine($"Value: {value}");
                }
                else
                {
                    Console.WriteLine("Value not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the read operation
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
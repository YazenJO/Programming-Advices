using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace a
{
    class Tempreture : EventArgs
    {
        public int OldTempreture;
        public int NewTempreture;
        public int Difference;

        public Tempreture(int oldTempreture, int newTempreture)
        {
            OldTempreture = oldTempreture;
            NewTempreture = newTempreture;
            Difference = Math.Abs(newTempreture - oldTempreture);
        }
    }

    class Thermostate
    {
        public event EventHandler<Tempreture> TempretureChanged;
        private int OldTempreture;
        private int CurrentTempreture;

        public void SetTempreture(int newTempreture)
        {
            if (OldTempreture != newTempreture)
            {
                OldTempreture = CurrentTempreture;
                CurrentTempreture = newTempreture;
                OnTempretureChanged(OldTempreture, CurrentTempreture);
            }
        }

        private void OnTempretureChanged(int oldTempreture, int newTempreture)
        {
            TempretureChanged?.Invoke(this, new Tempreture(oldTempreture, newTempreture));
        }
    }

    class Display
    {
        public void SubscribeToThermostate(Thermostate thermostate)
        {
            thermostate.TempretureChanged += DisplayTempreture;
        }

        public void DisplayTempreture(object sender, Tempreture e)
        {
            Console.WriteLine(
                $"Old Tempreture: {e.OldTempreture}, New Tempreture: {e.NewTempreture}, Difference: {e.Difference}");
        }
    }

    public class clsHashing
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string hashOfInput = HashPassword(password);
            return StringComparer.OrdinalIgnoreCase.Compare(hashOfInput, hashedPassword) == 0;
        }

        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine(clsHashing.HashPassword("1234"));
                /*
                Thermostate thermostate = new Thermostate();
                Display display = new Display();
                display.SubscribeToThermostate(thermostate);

                thermostate.SetTempreture(20);
                thermostate.SetTempreture(25);
                thermostate.SetTempreture(22);
                thermostate.SetTempreture(30);
                thermostate.SetTempreture(30); // No change, no event triggered*/
            }
        }
    }
}
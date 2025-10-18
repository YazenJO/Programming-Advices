using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_Battery_Info
{
    internal class Program
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte SystemStatusFlag;
            public uint BatteryLifeTime;
            public uint BatteryFullLifeTime;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS lpSystemPowerStatus);
        static void Main(string[] args)
        {
            SYSTEM_POWER_STATUS sps = new SYSTEM_POWER_STATUS();
            if (GetSystemPowerStatus(out sps))
            {
                Console.WriteLine("AC Line Status: " + sps.ACLineStatus);
                Console.WriteLine("Battery Flag: " + sps.BatteryFlag);
                Console.WriteLine("Battery Life Percent: " + sps.BatteryLifePercent);
                Console.WriteLine("System Status Flag: " + sps.SystemStatusFlag);
                Console.WriteLine("Battery Life Time: " + sps.BatteryLifeTime);
                Console.WriteLine("Battery Full Life Time: " + sps.BatteryFullLifeTime);
            }
            else
            {
                Console.WriteLine("Error getting power status");
            }
            Console.ReadLine();
        }
    }
}

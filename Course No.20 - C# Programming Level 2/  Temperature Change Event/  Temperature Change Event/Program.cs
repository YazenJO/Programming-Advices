using System;

namespace Temperature_Change_Event
{
    public class TemperatureChangeEventArgs : EventArgs
    {
        public double OldTemperature { get; }
        public double NewTemperature { get; }
        public double Diffrence { get; }

        public TemperatureChangeEventArgs(double oldTemperature, double newTemperature)
        {
            OldTemperature = oldTemperature;
            NewTemperature = newTemperature;
            Diffrence = Math.Abs(newTemperature - oldTemperature);
        }
    }

    public class Thermostate
    {
        public event EventHandler<TemperatureChangeEventArgs> TemperatureChange;
        public double oldTemperature;
        public double CurrentTemperature;

        public Thermostate(double oldTemperature, double newTemperature)
        {
            this.oldTemperature = oldTemperature;
            this.CurrentTemperature = newTemperature;
        }

        public void SetTemperature(double newTemperature)
        {
            if (newTemperature!=oldTemperature)
            {
                oldTemperature=CurrentTemperature;
                CurrentTemperature = newTemperature;
                OnTemperatureChange(oldTemperature,CurrentTemperature);
            }
            
        }

        private void OnTemperatureChange(double temperature, double newTemperature)
        {
            OnTemperatureChange(new TemperatureChangeEventArgs(temperature, newTemperature));
        }
        private void OnTemperatureChange(TemperatureChangeEventArgs e)
        {
            TemperatureChange?.Invoke(this,e);
        }
        
    }

    public class Desplay
    {
        public void Subscribe(Thermostate thermostate)
        {
            thermostate.TemperatureChange += OnTemperatureChange;
        }
        public void Unsubscribe(Thermostate thermostate)
        {
            thermostate.TemperatureChange -= OnTemperatureChange;
        }
        private void OnTemperatureChange(object sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine($"Old Temperature: {e.OldTemperature}");
            Console.WriteLine($"New Temperature: {e.NewTemperature}");
            Console.WriteLine($"Difference: {e.Diffrence}");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thermostate thermostate = new Thermostate(20, 25);
            Thermostate thermostate2 = new Thermostate(50, 25);
            Desplay desplay = new Desplay();
            desplay.Subscribe(thermostate2);
            desplay.Subscribe(thermostate);
            thermostate.SetTemperature(25);
            thermostate2.SetTemperature(25);
            thermostate.SetTemperature(30);
            desplay.Unsubscribe(thermostate2);
            thermostate2.SetTemperature(30);
        }
    }
}
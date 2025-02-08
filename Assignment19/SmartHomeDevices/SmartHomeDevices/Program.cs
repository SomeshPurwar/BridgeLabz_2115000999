using System;
namespace SmartHomeDevices
{
    class Device
    {
        public string deviceId;
        public string status;

        public Device(string deviceId, string status)
        {
            this.deviceId = deviceId;
            this.status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {deviceId}, Status: {status}");
        }

    }

    class Thermostat : Device
    {
        public int temperatureSetting;

        public Thermostat(string deviceId, string status, int temperatureSetting) : base(deviceId, status)
        {
            this.temperatureSetting = temperatureSetting;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine("Thermostat...");
            base.DisplayStatus();
            Console.WriteLine($"Temperature Setting: {temperatureSetting}°C");
        }
    }

    class Program
    {
        static void Main()
        {
            Device thermostat = new Thermostat("T12", "Online", 16);
            thermostat.DisplayStatus();
        }
    }
}
using System;

class Device
{
    public int DeviceId;
    public string Status;
}

class Thermostat : Device
{
    public int TemperatureSetting;

    public void ShowStatus()
    {
        Console.WriteLine(DeviceId + " " + Status + " " + TemperatureSetting);
    }
}

class Program
{
    static void Main()
    {
        Thermostat t = new Thermostat();
        t.DeviceId = 101;
        t.Status = "ON";
        t.TemperatureSetting = 25;

        t.ShowStatus();
    }
}

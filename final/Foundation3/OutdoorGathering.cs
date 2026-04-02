using System;
using System.ComponentModel.DataAnnotations;

class OutdoorGather : Event
{
    // Variables
    private string _weather;

    // Constructor
    public OutdoorGather(string weather, DateTime dateTime, Address address) : base("Sunset in the Park", "Come enjoy a relaxing afternoon outdoors with games, food, and great company. Bring your family and friends for a fun filled evening under the open sky!", dateTime, address)
    {
        _weather = weather;
    }

    // Methods
    public void DisplayWeather()
    {
        Console.WriteLine($"Weather report: {_weather}");
    }
}
using System;
using System.ComponentModel.DataAnnotations;

class Event
{
    // Variables
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    // Constructor
    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }
    // Methods
    public void DisplayIntro()
    {
        Console.WriteLine("--NEW EVENT--\n");
        Console.WriteLine($"{_title}\n");
        Console.WriteLine($"{_description}\n\n");
    }
    public void DisplayWhenWhere()
    {
        Console.WriteLine($"\n\nThe event will be held at: \n{_address.GetFullAddress()}\n");
        Console.WriteLine($"When: \n{_dateTime:MM/dd/yyyy} at {_dateTime:hh:mm tt}\n\n");
    }

}
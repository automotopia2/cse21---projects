using System;

class Activity
{
    // Variables
    private string _name;
    private string _description;

    // Methods
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_description}");
    }
}
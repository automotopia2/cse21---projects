using System;
using System.Diagnostics;

class Activity
{
    // Variables
    private string _name;
    private string _description;
    public Stopwatch stopwatch = new Stopwatch();

    // Methods
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }
    public void Spinner(int spinnerLength)
    {
        string emDash = "\u2014";
        List<string> myList = new List<string> { "|", "/", emDash, @"\"};
        // Console.WriteLine("The activity will begin soon. ");
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < spinnerLength)
        {
            foreach (string i in myList)
            {
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }    
    }
}
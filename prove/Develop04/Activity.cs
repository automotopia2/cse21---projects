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
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }
    public void Spinner(int spinnerLength)
    {
        string emDash = "\u2014";
        Console.Clear();
        List<string> myList = new List<string> { "|", "/", emDash, @"\"};
        Console.WriteLine("The activity will begin soon. ");
        int spinAmount = 0;
        while (spinAmount < spinnerLength*2)
        {
            foreach (string i in myList)
            {
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write("\b \b");
                spinAmount ++;
            }
        }    
    }
}
using System;

class Lecture : Event
{
    // Variables
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string speaker, int capacity, DateTime dateTime, Address address) : base("I Can Do It.", "Journey with us into the world of self control! Learn of the ways you can take control of your life!", dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }   
    public void DisplaySpeakCap()
    {
        Console.WriteLine($"Guest speaker: {_speaker}.\n");
        Console.WriteLine($"Limited seating capacity of {_capacity}.");
        Console.WriteLine("Please reserve seats ahead of time.");
    }
}
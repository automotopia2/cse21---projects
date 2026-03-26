using System;
using System.Diagnostics;


class Listening : Activity
{
    // Variables 

    // Constructor
    public Listening() : base("Listening", "This activity will help you relax by giving you a prompt that you can respond to with many answers.")
    {
        
    }

    public void Listener(int time)
    {
        Stopwatch listening = new Stopwatch();        
        PromptGen2 prompt1 = new PromptGen2();

        listening.Start();
        while (listening.Elapsed.TotalSeconds < time)
        {
            
        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the Reflection exercise."); 
        Thread.Sleep(6000);
    }
}
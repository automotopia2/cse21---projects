using System;

class Listening : Activity
{
    // Variables 

    // Constructor
    public Listening() : base("Listening", "This activity will help you relax by giving you a prompt that you can respond to with many answers.")
    {
        
    }

    public void Listener(int time)
    {
        int elapsedTime = 0;
        
        PromptGen2 prompt1 = new PromptGen2();
        while (elapsedTime < time)
        {
            
        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the Reflection exercise."); 
        Thread.Sleep(8000);
    }
}
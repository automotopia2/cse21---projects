using System;

class Breathing : Activity
{
    // Variables 

    // Constructor
    public Breathing() : base("Welcome to the Breathing Activity.", "This activity will help you relax by walking you through a timed breathing exercise.")
    {
        
    }
    public void BreathPacer(int time)
    {
        int elapsedTime = 0;
            Console.Clear();
            Console.WriteLine("Get Ready...");
            Thread.Sleep(3000);
            Console.WriteLine("and...");
            Thread.Sleep(2000);
        
        while (elapsedTime < time )
        {
            Console.Write("\nInhale... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                elapsedTime ++;
                Console.Write("\b \b");
            }
            Console.Write("\nExhale... ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                elapsedTime ++;
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the breathing exercise."); 
        Thread.Sleep(8000);
    }     
}
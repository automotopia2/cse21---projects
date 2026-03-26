using System;
using System.Diagnostics;


class Breathing : Activity
{
    // Variables 

    // Constructor
    public Breathing() : base("Welcome to the Breathing Activity.", "This activity will help you relax by walking you through a timed breathing exercise. Focus on your rate of breathing to help you body feel at ease.")
    {
        
    }
    public void BreathPacer(int time)
    {
        Stopwatch breathPacer = new Stopwatch();
        Console.Clear();
        Console.WriteLine("The activity will begin soon. ");
        Spinner(5);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);
        Console.WriteLine("and...");
        Thread.Sleep(2000);
        breathPacer.Start();

        while (breathPacer.Elapsed.TotalSeconds < time )
        {
            Console.Write("\nInhale... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                Console.Write("\b \b");
            }
            Console.Write("\nExhale... ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the breathing exercise."); 
        Thread.Sleep(6000);
    }     
}
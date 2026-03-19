using System;

class Breathing : Activity
{
    // Variables 

    // Constructor
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through a timed breathing exercise.")
    {
        
    }
    public void BreathPacer(int time)
    {
        int elapsedTime = 0;
        
        while (elapsedTime < time)
        {
            Console.Write("\n\nBreath in: ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                elapsedTime ++;
                Console.Write("\b \b");
            }
            Console.Write("\n\nBreath out: ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                elapsedTime ++;
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("\nGreat job!"); 
    }     
}
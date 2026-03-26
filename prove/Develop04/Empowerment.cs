using System;
using System.Diagnostics;


class Empowerment : Activity
{
    // Variables 

    // Constructor
    public Empowerment() : base("Welcome to the Empowerment Activity.", "This activity will provide you with positive messages and reminders. Never forget to take care of yourself and always remember your worth.")
    {
        
    }

    // Methods
    public void Empower(int time)
    {
        string affirmation = "Affirmations.txt";
        Stopwatch empower = new Stopwatch();        
        PromptGen2 affirmationPrompt = new PromptGen2();


        Console.Write("Get Ready...");
        Spinner(5);
        Console.WriteLine();
        Console.WriteLine("\nNow ponder and think on the questions that pop up.");
        Console.Write("You may begin in ");
        for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                Console.Write("\b \b");
            }
        Console.Clear();
        empower.Start();

        while (empower.Elapsed.TotalSeconds < time)
        {
            affirmationPrompt.GetPrompt(affirmation);
            affirmationPrompt.DisplayPromptQuestion();
            Console.WriteLine("\n");
            Spinner(8);
        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the Empowerment Activity."); 
        Thread.Sleep(6000);
    }
}
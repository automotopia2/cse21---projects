using System;
using System.Diagnostics;


class Reflection : Activity
{
    // Variables 

    // Constructor
    public Reflection() : base("Welcome to the Reflection Activity", "This activity will help you relax by reflecting on your day and how you felt.")
    {
        
    }

    public void Reflector(int time)
    {
        Stopwatch reflector = new Stopwatch();
        string promptLibrary = "Prompts.txt";
        string promptQuestionLibrary = "PromptQuestion.txt";
        
        PromptGen2 prompt1 = new PromptGen2();
        PromptGen2 promptQuestion = new PromptGen2();
        prompt1.GetPrompt(promptLibrary);

        Console.WriteLine("Get ready...");
        Spinner(5);
        Console.WriteLine();
        Console.WriteLine("\nConsider the following prompt:\n");
        prompt1.DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("Press enter when you have something in mind.");
        Console.ReadLine();
        Console.Clear();
        reflector.Start();

        while (reflector.Elapsed.TotalSeconds < time)
        {
            promptQuestion.GetPrompt(promptQuestionLibrary);
            promptQuestion.DisplayPromptQuestion();
            Console.WriteLine("\n");
            Spinner(8);
            Thread.Sleep(3000);
        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the Reflection exercise."); 
        Thread.Sleep(6000);
    }     
    
}
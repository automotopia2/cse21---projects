using System;

class Reflection : Activity
{
    // Variables 

    // Constructor
    public Reflection() : base("Welcome to the Reflection Activity", "This activity will help you relax by reflecting on your day and how you felt.")
    {
        
    }

    public void Reflector(int time)
    {
        int elapsedTime = 0;
        string promptLibrary = "Promps.txt";
        string promptQuestionLibrary = "PromptQuestion.txt";
        
        PromptGen2 prompt1 = new PromptGen2();
        PromptGen2 promptQuestion = new PromptGen2();
        prompt1.GetPrompt(promptLibrary);
        prompt1.DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("Press enter when you have something in mind.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();

        while (elapsedTime < time)
        {
            promptQuestion.GetPrompt(promptQuestionLibrary);
            promptQuestion.DisplayPromptQuestion();
            Spinner(8);

        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the Reflection exercise."); 
        Thread.Sleep(8000);
    }     
    
}
using System;
using System.Diagnostics;


class Listening : Activity
{
    // Variables 

    // Constructor
    public Listening() : base("Welcome to the Listening Activity.", "This activity will give you a question to reflect on. You will respond to this prompt with as many answers as you can think of.")
    {
        
    }

    // Methods
    public void Listener(int time)
    {
        string listenPrompts = "ListenPrompts.txt";
        Stopwatch listening = new Stopwatch();        
        PromptGen2 Question = new PromptGen2();

        Question.GetPrompt(listenPrompts);

        Console.Write("Get Ready...");
        Spinner(5);
        Console.WriteLine("\n");
        Console.WriteLine($"List as many responses as you can to the to teh following prompt:");
        Question.DisplayPrompt();
        Console.Write("You may begin in ");
        for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                Console.Write("\b \b");
            }
        listening.Start();
        Console.WriteLine();
        while (listening.Elapsed.TotalSeconds < time)
        {
            // Console.WriteLine();
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine($"\nGreat job! You completed another {time} seconds of the Reflection exercise."); 
        Thread.Sleep(6000);
    }
}
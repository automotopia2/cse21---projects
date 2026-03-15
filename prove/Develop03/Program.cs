using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary("scripturesList.txt");
        Scripture scripture = library.GetRandomScripture();


        while (!scripture.IsCompleted())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            Console.Write("Press 'Enter' to get your scripture or type 'quit' to exit: ");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nNicely done! Keep fighting the good fight!");
    }
    
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string play_again = "";
        while (play_again != "no")
        {
        // Console.Write("What would you like the magic number to be? ");
        // int magic_num = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 100);
        int guess = 999;
        int try_tracker = 0;

        while (guess != magic_num)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        try_tracker = try_tracker + 1;
        if (guess == magic_num)
        {
            Console.WriteLine($"Correct! The magic number is {magic_num}");
        }
        else if (guess < magic_num)
        {
            Console.WriteLine("Guess a higher number.");
        }
        else if (guess > magic_num)
        {
            Console.WriteLine("Guess a lower number.");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
        }
        Console.WriteLine($"It took you {try_tracker} guesses!");

        Console.Write("Would you like to play again? Please enter 'yes' or 'no' here: ");
        play_again = Console.ReadLine();        
        }
        Console.WriteLine("Thank you for playing! Have a wonderful day!");
    }
}
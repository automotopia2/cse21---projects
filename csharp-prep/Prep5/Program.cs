using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int age = PromptUserBirthday();
        int fave_num = PromptUserNumber();
        int square_num = SquareNumber(fave_num);
        DisplayResults(name, age, square_num);

    }

    //FUNCTIONS
    static void DisplayWelcome()
    {
        // Prints the words "Welcome to the program!"
        Console.WriteLine("Welcome to the program!");
    }
        
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int fav_num = int.Parse(Console.ReadLine());
        return fav_num;
    }

    static int SquareNumber(int x)
    {
        x = x * x;
        return x;
    }

    static int PromptUserBirthday()
    {
        Console.Write("What year were you born? ");
        int birth_year = int.Parse(Console.ReadLine());
        int age = 2026 - birth_year;
        return age;
    }

    static void DisplayResults(string name, int age, int num_square)
    {
        Console.WriteLine($"{name}, the square of your number is {num_square}.");
        Console.Write($"{name}, you will turn {age} this year.");
    }

}
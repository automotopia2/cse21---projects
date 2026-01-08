using System;

class Program
{
    static void Main(string[] args)
    {
        // JAMES BOND NAME DISPLAY


        // Console.Write("What is your first name? ");
        // string firstname = Console.ReadLine();

        // Console.Write("What is your last name? ");
        // string lastname = Console.ReadLine();

        // Console.WriteLine($"\nYour name is {lastname}, {firstname} {lastname}.");



        // GRADE CALCULATOR //

        // Recording grade percentage
        Console.Write("Please enter your grade percentage here ");
        string enteredNum = Console.ReadLine();

        // Declaring variable and converting string to int
        int gradeNum = int.Parse(enteredNum);
        string Letter = "";
        
        // Convert percentage to letter grade
        if (gradeNum >= 90)
        {
            Letter = "A";
        }
        else if (gradeNum >= 80)
        {
            Letter = "B";
        }
        else if (gradeNum >= 70)
        {
            Letter = "C";
        }
        else if (gradeNum >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        // Print letter grade, then print pass or fail
        Console.Write($"Your letter grade is {Letter}. ");
        
        if (gradeNum >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the class. Please try again next semester!");
        }
    }
}
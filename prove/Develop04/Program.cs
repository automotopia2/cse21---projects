using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int menuChoice = 0;
        
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program!\n");
        Thread.Sleep(5000);
        while (menuChoice != 5)
        {
            Console.Clear();
            menuChoice = menu.DisplayMenu();
            menu.ReadMenu(menuChoice);
        
        }
    }    
}

// For the exceeding expectations, I added a 4th activity that displays encouraging messages and reminders to take care of yourself. 
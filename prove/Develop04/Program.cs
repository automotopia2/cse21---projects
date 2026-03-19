using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int menuChoice = 0;
        
        Console.WriteLine("Welcome to the Mindfulness Program!");
        menuChoice = menu.DisplayMenu();
        menu.ReadMenu(menuChoice);
        
    }
}
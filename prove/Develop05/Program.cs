using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int menuChoice = 0;
        
        while (menuChoice != 7)
        {
            Console.Clear();

            menuChoice = menu.DisplayMenu();
            menu.ReadMenu(menuChoice);
        
        }
    }
}

// I exceeded requirements by adding an option to delete a goal.
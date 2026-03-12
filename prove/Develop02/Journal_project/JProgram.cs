using System;
using System.Runtime.InteropServices;

class JournalProgram
{
    static void Main(string[] args)
        {
            // Create new instance of Menu
            Menu menu = new Menu();
            int menuChoice = 99;
            while(menuChoice != 6)
            {
                // Run the menu
                menuChoice = menu.DisplayMenu();
                menu.ReadMenu(menuChoice);
            }
        }    

}
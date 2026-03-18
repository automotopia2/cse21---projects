using System;
using System.ComponentModel.DataAnnotations;

class Menu
{
    // Variables 

    // Methods
    public int DisplayMenu()
    {
        Console.Write("What would Activity would you like to do? \n1) Breathing Activity \n2) Reflection Activity \n3) Listening Activity \nEnter the number correlating with the activity you would like to do here: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    
    public void ReadMenu(int choice)
    {
        if (choice == 1)
        {
            
        }
        else if (choice == 2)
        {
            
        }
        else if (choice == 3)
        {
            
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
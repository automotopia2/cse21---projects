using System;
using System.ComponentModel.DataAnnotations;

class Menu
{
    // Variables 
    private int _menuChoice;
    // Methods
    public void Pause()
    {
        Thread.Sleep(1000);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
    }
    public int GetTime()
    {
        Console.Write("How long would you like this activity to last?");
        int time = int.Parse(Console.ReadLine());
        return time;
    }
    public int DisplayMenu()
    {
        Console.Write("What would Activity would you like to do? \n1) Breathing Activity \n2) Reflection Activity \n3) Listening Activity \nEnter the number correlating with the activity you would like to do here: ");
        _menuChoice = int.Parse(Console.ReadLine());
        return _menuChoice;
    }
    
    public void ReadMenu(int choice)
    {
        if (choice == 1)
        {
            Breathing breathing = new Breathing();
            breathing.DisplayIntro();

        }
        else if (choice == 2)
        {
            Reflection reflection = new Reflection();
            int time = int.Parse(Console.ReadLine());
            while (int time < entered time)
            {
                
            }
        }
        else if (choice == 3)
        {
            Listening listening = new Listening();
        }
        else if (choice == 4)
        {
            Console.WriteLine("Thank you for taking care of yourself! Have a wonderful day!");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
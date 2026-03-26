using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
using System.Diagnostics;


class Menu
{
    // Variables 
    private int _menuChoice;
    
    // Methods                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
    public int GetTime()
    {
        Console.Write("How long would you like this activity to last? ");
        int time = int.Parse(Console.ReadLine());
        return time;
    }
    public int DisplayMenu()
    {
        Console.Write("What would Activity would you like to do? \n1) Breathing Activity \n2) Reflection Activity \n3) Listening Activity \n4) Empowerment Acitivity \n5) Quit Program \nEnter the number correlating with the activity you would like to do here: ");
        _menuChoice = int.Parse(Console.ReadLine());
        return _menuChoice;
    }
    
    public void ReadMenu(int choice)
    {
            if (choice == 1)
            {
                Console.Clear();
                Breathing breathing = new Breathing();
                breathing.DisplayIntro();
                Console.WriteLine();
                int time = GetTime();
                breathing.BreathPacer(time);
            }
            else if (choice == 2)
            {
                Console.Clear();
                Reflection reflection = new Reflection();
                reflection.DisplayIntro();
                Console.WriteLine();
                int time = GetTime();
                Console.Clear();
                reflection.Reflector(time);
                // DisplayPrompt

            }
            else if (choice == 3)
            {
                Console.Clear();
                Listening listening = new Listening();
                listening.DisplayIntro();
                Console.WriteLine();
                int time = GetTime();
                listening.Listener(time);
            }
            else if (choice == 4)
            {
                Console.Clear();
                Empowerment empowerment = new Empowerment();
                empowerment.DisplayIntro();
                Console.WriteLine();
                int time = GetTime();
                empowerment.Empower(time);
            }
            else if (choice == 5)
            {
                Console.Clear();
                Console.WriteLine("Thank you for taking care of yourself! Have a wonderful day!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                Thread.Sleep(8000);
            }
    }
}
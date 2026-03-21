using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Menu
{
    // Variables 
    private int _menuChoice;
    // Methods
    public void Spinner()
    {
        List<string> myList = new List<string> { "|", "/", "-", "L"};
        Console.WriteLine("The activity will begin soon. ");
        int spinAmount = 0;
        while (spinAmount < 15)
        {
            foreach (string i in myList)
            {
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write("\b \b");
                spinAmount ++;
            }
        }    
    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
    public int GetTime()
    {
        Console.Write("How long would you like this activity to last? ");
        int time = int.Parse(Console.ReadLine());
        return time;
    }
    public int DisplayMenu()
    {
        Console.Write("What would Activity would you like to do? \n1) Breathing Activity \n2) Reflection Activity \n3) Listening Activity \n4) Quit Program \nEnter the number correlating with the activity you would like to do here: ");
        _menuChoice = int.Parse(Console.ReadLine());
        return _menuChoice;
    }
    
    public void ReadMenu(int choice)
    {
            if (choice == 1)
            {
                Breathing breathing = new Breathing();
                Console.WriteLine();
                breathing.DisplayIntro();
                int time = GetTime();
                Spinner();
                breathing.BreathPacer(time);
            }
            else if (choice == 2)
            {
                Reflection reflection = new Reflection();
                int enteredTime = int.Parse(Console.ReadLine());
                // while (int time < enteredTime)
                // {
                    
                // }
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
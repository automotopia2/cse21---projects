using System;

class Menu
{
    // Variables 
    private int _menuChoice;
    private GoalTracker _tracker = new GoalTracker();
    // Methods                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
    public int DisplayMenu()
    {
        Console.Write($"Menu Options: \n    1) Create New Goal \n    2) List Goals \n    3) Save Goals \n    4) Load Goals \n    5) Record Event \n    6) Delete Goal \n    7) Quit \nEnter the number correlating with your choice: ");
        _menuChoice = int.Parse(Console.ReadLine());
        return _menuChoice;
    }
    
    public void ReadMenu(int choice)
    {
            if (choice == 1)
            {
                Console.Clear();
                _tracker.CreateGoal();
                Thread.Sleep(2000);

            }
            else if (choice == 2)
            {
                Console.Clear();
                
            }
            else if (choice == 3)
            {
                Console.Clear();
                
            }
            else if (choice == 4)
            {
                Console.Clear();
                
            }
            else if (choice == 5)
            {
                Console.Clear();
                _tracker.RecordEvent();
                Thread.Sleep(2000);

            }
            else if (choice == 6)
            {
                Console.Clear();
                
            }
            else if (choice == 7)
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the program! Have a wonderful day!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                Thread.Sleep(5000);
            }
    }
}
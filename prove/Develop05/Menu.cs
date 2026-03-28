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
                _tracker.ListGoals();
                Console.Write("\nPress enter when you are done looking at your goals.");
                Console.ReadLine();
            }
            else if (choice == 3) // Save Goals
            {
                string filename = "SavedGoals.txt";
                Console.Clear();
                _tracker.SaveGoals(filename);
                Thread.Sleep(3000);
            }
            else if (choice == 4) // Load Goals
            {
                string filename = "SavedGoals.txt";
                Console.Clear();
                _tracker.LoadGoals(filename);
                Thread.Sleep(2000);
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
                _tracker.ListGoals();
                Console.Write("Enter the nummber of the goal you would like to delete:  ");
                int goalsIndex = int.Parse(Console.ReadLine());
                _tracker.DeleteGoal(goalsIndex - 1);
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
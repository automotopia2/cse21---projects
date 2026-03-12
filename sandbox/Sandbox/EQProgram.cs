using System;

class EQProgram
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest");
            manager.DisplayScore();

            Console.WriteLine("\n1 Create Simple Goal");
            Console.WriteLine("2 Create Eternal Goal");
            Console.WriteLine("3 Create Checklist Goal");
            Console.WriteLine("4 List Goals");
            Console.WriteLine("5 Record Event");
            Console.WriteLine("6 Save Goals");
            Console.WriteLine("7 Load Goals");
            Console.WriteLine("8 Quit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.AddGoal(new SimpleGoal("Read Scriptures", "Read today", 100));
                    break;

                case "2":
                    manager.AddGoal(new EternalGoal("Pray", "Daily prayer", 50));
                    break;

                case "3":
                    manager.AddGoal(new ChecklistGoal("Temple", "Attend temple", 100, 5, 500));
                    break;

                case "4":
                    manager.ListGoals();
                    break;

                case "5":
                    manager.ListGoals();
                    Console.Write("Which goal completed? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;

                case "6":
                    Console.Write("Filename: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;

                case "7":
                    Console.Write("Filename: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case "8":
                    running = false;
                    break;
            }
        }
    }
}
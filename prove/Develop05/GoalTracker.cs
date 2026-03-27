using System;
using System.Collections.Generic;

class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int Score() 
    { 
        return _score; 
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("    1) Simple Goal");
        Console.WriteLine("    2) Eternal Goal");
        Console.WriteLine("    3) Checklist Goal");
        Console.Write("Enter your choice: ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the number of points this goal is worth: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == 3)
        {
            Console.Write("Enter the number of times this goal must be completed: ");
            int requiredTimes = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points for completing this goal: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, requiredTimes, bonusPoints));
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Goal created successfully!");
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine($"Your current score is: {_score}");
        Console.WriteLine();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"    {i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record an event for!");
            return;
        }

        ListGoals();
        Console.Write("Enter the number of the goal you completed: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Your total score is now {_score}.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals(string filename)
    {
        StreamWriter outputFile = new StreamWriter(filename);
        outputFile.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
        outputFile.Close();
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4])));
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }

    public void DeleteGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            Console.WriteLine($"'{_goals[index].GetDetailsString()}' has been deleted.");
            _goals.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}
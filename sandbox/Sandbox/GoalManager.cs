using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Level: {GetLevel()}");
    }

    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
        Console.WriteLine($"New Score: {_score}");
        Console.WriteLine($"Level: {GetLevel()}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}
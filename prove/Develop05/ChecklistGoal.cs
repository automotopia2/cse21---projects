using System;

class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _requiredTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredTimes, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _requiredTimes = requiredTimes;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string name, string description, int points, int requiredTimes, int bonusPoints, int timesCompleted) : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
        _requiredTimes = requiredTimes;
        _bonusPoints = bonusPoints;
    }
    public override int RecordEvent()
    {
        if (_timesCompleted < _requiredTimes)
        {
            _timesCompleted++;
            if (_timesCompleted == _requiredTimes)
            {
                Console.WriteLine("Congratulations! You completed the checklist goal and earned a bonus!");
                return GetPoints() + _bonusPoints;
            }
            return GetPoints();
        }
        Console.WriteLine("This goal is already complete!");
        return 0;
    }

    public override string GetDetailsString()
    {
        string checkbox;
        if (_timesCompleted >= _requiredTimes)
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {GetName()} - {GetDescription()} (Completed {_timesCompleted}/{_requiredTimes} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_timesCompleted}|{_requiredTimes}|{_bonusPoints}";
    }
}
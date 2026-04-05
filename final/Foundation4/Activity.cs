using System;

abstract class Activity
{
    // Variables
    private DateTime _date;
    private double _time;
    private string _activityType;
    // private double _distance;
    // private double _speed;
    // private double _pace;
    // Constructor
    public Activity(DateTime date, double time, string activityType)
    {
        _date = date;
        _time = time;
        _activityType = activityType;
    }
    // Regular Methods
    public double GetTime()
    {
        return _time;
    }
    // Abstract Methods
    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }
    public string DisplaySummary()
    {
        return $"{_date:dd} {_date:MMM} {_date:yyyy} {_activityType} ({_time} min): \nDistance: {CalculateDistance():F2} km \nSpeed: {CalculateSpeed():F2} kph \nPace: {CalculatePace():F2} min per km";
    }
}
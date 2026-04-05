using System;
using System.IO.Pipes;

class LapSwim : Activity
{
    // Variables
    private double _laps;
    // Constructor
    public LapSwim(DateTime date, double time, double laps) : base(date, time, "Swimming Laps")
    {
        _laps = laps;
    }
    // Abstract Methods
    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (CalculateDistance() / GetTime()) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = GetTime() / CalculateDistance();
        return pace;
    }
}
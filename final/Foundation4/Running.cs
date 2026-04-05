using System;

class Running : Activity
{
    // Variables
    private double _distance;
    // Constructor
    public Running(DateTime date, double time, double distance) : base(date, time, "Running")
    {
        _distance = distance;
    }
    // Abstract Methods
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        double speed = _distance / GetTime();
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = GetTime() / _distance;
        return pace;
    }
}
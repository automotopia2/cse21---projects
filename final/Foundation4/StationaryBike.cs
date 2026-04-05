using System;

class StationaryBike : Activity
{
    // Variables
    private double _speed;
    // Constructor
    public StationaryBike(DateTime date, double time, double speed) : base(date, time, "Stationary Bike")
    {
        _speed = speed;
    }
    // Abstract Methods
    public override double CalculateDistance()
    {
        double distance = _speed * GetTime();
        return distance;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        double pace = GetTime() / CalculateDistance();
        return pace;
    }    
}
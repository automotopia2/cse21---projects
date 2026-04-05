using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Running
        DateTime dateTimeR = new DateTime(2026, 4, 2);
        Running running = new Running(dateTimeR, 45, 5.5);
        activities.Add(running);

        // Stationary Bike
        DateTime dateTimeSB = new DateTime(2026, 8, 15);
        StationaryBike stationaryBike = new StationaryBike(dateTimeSB, 30, 10);
        activities.Add(stationaryBike);

        // Swimming Laps
        DateTime dateTimeLS = new DateTime(2026, 3, 7);
        LapSwim lapSwim = new LapSwim(dateTimeLS, 20, 1);
        activities.Add(lapSwim);


    // OUTPUTS
        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine("\n__NEW ACTIVITY__");
            Console.WriteLine(activity.DisplaySummary());
            Console.WriteLine("\n");
        }
    }
}
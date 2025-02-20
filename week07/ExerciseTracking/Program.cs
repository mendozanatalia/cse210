using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("Running", 30, 4.8),
            new Cycling("Cycling", 30, 4.8),
            new Swimming("Swimming", 30, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
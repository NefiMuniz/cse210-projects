using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            // Create activities
            new Running("10 Jul 2024", 60, 10.0),
            new Cycling("11 Jul 2024", 30, 20.0),
            new Swimming("12 Jul 2024", 90, 60),
            new Running("15 Jul 2024", 30, 4.8),
            new Cycling("16 Nov 2024", 45, 25.0),
            new Swimming("18 Nov 2024", 60, 40)
        };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

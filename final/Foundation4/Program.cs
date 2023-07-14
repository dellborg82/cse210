using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create activities and add them to the list
        activities.Add(new Running("Running", "6/24/2023", 60, 7.5));
        activities.Add(new BikeActivity("Stationary Bicycles", "6/24/2023", 90, 30));
        activities.Add(new Swimming("Swimming", "6/24/2023", 60, 20));

        // Iterate through the list and display the summary of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
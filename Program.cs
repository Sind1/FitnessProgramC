using System;
using System.Collections.Generic;

public class Program
{
    // Custom delegate
    public delegate void ActivityLogged(string activity, int duration);

    static void Main(string[] args)
    {
        FitnessTracker tracker = new FitnessTracker();
        ConsoleLogger logger = new ConsoleLogger();

        // Multicast delegate
        ActivityLogged loggerDelegate = new ActivityLogged(LogToConsole);
        loggerDelegate += LogToConsole;


        tracker.AddActivity("Running", 30);
        tracker.AddActivity("Cycling", 45);
        tracker.AddActivity("Swimming", 60);

        tracker.DisplayActivities();

        LogActivitiesToConsole(tracker, loggerDelegate);
    }

    static void LogToConsole(string activity, int duration)
    {
        Console.WriteLine($"Custom Log: {activity}, {duration} minutes");
    }

    static void LogActivitiesToConsole(FitnessTracker tracker, ActivityLogged logger)
    {
        foreach (var kvp in tracker.activityDictionary)
        {
            logger?.Invoke(kvp.Key, kvp.Value);
        }
    }
}
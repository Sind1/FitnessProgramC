
// S - Single Responsibility Principle
// Atsakomybė už sekimą priskiriama šiai klasėi.

public class FitnessTracker
{
    // O - Open/Closed Principle
    // Galimybė pridėti naujus veiklos tipus be esamos klasės modifikacijos.
    public Dictionary<string, int> activityDictionary;

    public FitnessTracker()
    {
        activityDictionary = new Dictionary<string, int>();
    }

    public Dictionary<string, int> AddActivity(string activity, int duration)
    {
        if (activityDictionary.ContainsKey(activity))
        {
            activityDictionary[activity] += duration;
        }
        else
        {
            activityDictionary.Add(activity, duration);
        }
        return activityDictionary;
    }

    public void DisplayActivities()
    {
        foreach (var kvp in activityDictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} minutes");
        }
    }
}
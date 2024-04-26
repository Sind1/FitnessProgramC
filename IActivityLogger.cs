

public interface IActivityLogger
{
    void LogActivity(string activity, int duration);
    // void LogDictionary<TKey, TValue>(Dictionary <TKey, TValue> dictionary) where TKey : notnull;
}


public class ConsoleLogger : IActivityLogger
{
    public void LogActivity(string activity, int duration)
    {
        Console.WriteLine($"Logged: {activity}, {duration} minutes");
        
    }
    // public void LogDictionary<TKey, TValue>(Dictionary <TKey, TValue>){

    // }
}
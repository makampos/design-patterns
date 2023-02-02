using MoreLinq.Extensions;

namespace singleton;
using static System.Console;

public class SingletonDatabase : IDatabase
{
    private Dictionary<string, int> capitals;
    private SingletonDatabase()
    {
        WriteLine("Initializing database (...)");
        capitals = File.ReadAllLines($"capitals.txt")
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1))
            );
    }
    
    public int GetPopulation(string name)
    {
        return capitals[name];
    }

    private static Lazy<SingletonDatabase> instance = 
        new Lazy<SingletonDatabase>(() => new SingletonDatabase());
    public static SingletonDatabase Instance => instance.Value;
}
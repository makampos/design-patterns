using MoreLinq.Extensions;
using static  System.Console;

namespace singleton;

public class OrdinaryDatabase : IDatabase
{
    private readonly Dictionary<string, int> _capitals;
    public OrdinaryDatabase()
    {
        WriteLine("Initializing database (...)");
        _capitals = File.ReadAllLines($"capitals.txt")
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1))
            );
    }
    public int GetPopulation(string name)
    {
        return _capitals[name];
    }
}
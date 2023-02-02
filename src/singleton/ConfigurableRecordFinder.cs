namespace singleton;

public class ConfigurableRecordFinder
{
    private IDatabase _database;

    public ConfigurableRecordFinder(IDatabase data)
    {
        _database = data ?? throw new ArgumentNullException(nameof(data));
    }
    
    public int GetTotalPopulation(IEnumerable<string> names)
    {
        var result = 0;
        foreach (var name in names)
        {
            result += _database.GetPopulation(name);
        }
        return result;
    }
}
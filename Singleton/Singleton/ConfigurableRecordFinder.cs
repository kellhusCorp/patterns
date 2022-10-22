namespace Singleton;

public class ConfigurableRecordFinder
{
    private readonly IDatabase database;

    public ConfigurableRecordFinder(IDatabase database)
    {
        this.database = database;
    }

    public int TotalPopulation(IEnumerable<string> names)
    {
        return names.Sum(name => database.GetPopulation(name));
    }
}
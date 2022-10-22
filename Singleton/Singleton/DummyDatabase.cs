namespace Singleton;

public class DummyDatabase : IDatabase
{
    public int GetPopulation(string city)
    {
        return new Dictionary<string, int>
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3
        }[city];
    }
}
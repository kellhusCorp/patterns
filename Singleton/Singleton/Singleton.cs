using MoreLinq.Extensions;

namespace Singleton;

public class SingletonDatabase : IDatabase
{
    private Dictionary<string, int> capitals;

    private SingletonDatabase()
    {
        var dataFromFile = File.ReadAllLines(
                Path.Combine(
                    new FileInfo(typeof(SingletonDatabase).Assembly.Location).DirectoryName,
                    "capitals.txt"))
            .Batch(2);
        capitals = dataFromFile.ToDictionary(
            list => list.ElementAt(0).Trim(),
            list => int.Parse(list.ElementAt(1))
        );
    }

    public int GetPopulation(string city) => capitals[city];

    private static Lazy<SingletonDatabase> instance = new(() => new SingletonDatabase());

    public static SingletonDatabase Instance => instance.Value;
}
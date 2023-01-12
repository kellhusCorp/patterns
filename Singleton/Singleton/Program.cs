using Singleton;

static class Program
{
    static void Main()
    {
        var db = SingletonDatabase.Instance;

        var city = "Moscow";

        Console.WriteLine($"{city} имеет популяцию в {db.GetPopulation(city)}");
    }
}
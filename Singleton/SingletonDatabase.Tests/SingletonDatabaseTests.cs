using NUnit.Framework;
using Singleton;

namespace SingletonDatabase.Tests;

public class SingletonDatabaseTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Is_Singleton()
    {
        var firstDb = Singleton.SingletonDatabase.Instance;
        var secondDb = Singleton.SingletonDatabase.Instance;
        Assert.That(firstDb, Is.SameAs(secondDb));
    }

    [Test]
    public void Test_Dependent_Total_Population()
    {
        var db = new DummyDatabase();
        var rf = new ConfigurableRecordFinder(db);
        var names = new[] {"first", "second", "third"};

        var result = rf.TotalPopulation(names);
        
        Assert.That(result, Is.EqualTo(6));
    }
}
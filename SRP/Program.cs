using SRP.Domain;

static class Program
{
    static void Main()
    {
        var j = new Journal();
        j.AddEntry("test");
        j.AddEntry("test 1");
        Console.WriteLine(j);

        var p = new PersistenceManager();
        var filename = @"c:\users\XXX\desktop\example.txt";
        p.Save(j, filename, true);
    }
}
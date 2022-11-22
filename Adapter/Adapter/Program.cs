using System.Text;
using System.Xml.Serialization;

namespace Adapter;

static class Program
{
    private static readonly List<VectorObject> vectorObjects
        = new()
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6),
        };

    private static void DrawPoints()
    {
        foreach (var vectorObject in vectorObjects)
        {
            foreach (var line in vectorObject)
            {
                var adapter = new LineToPointAdapter(line);
                foreach (var point in adapter)
                {
                    DrawPoint(point);
                }
            }
        }
    }

    private static void DrawPoint(Point p)
    {
        Console.Write(".");
    }
    
    static void Main()
    {
        DrawPoints();
        DrawPoints();
        Console.ReadKey();
        var stats = new CountryStats();
        stats.Capitals.Add("Russia", "Moscow");

        var xs = new XmlSerializer(typeof(CountryStats));
        var sb = new StringBuilder();
        var sw = new StringWriter(sb);
        xs.Serialize(sw, stats);
        var newStats = (CountryStats) xs.Deserialize(new StringReader(sb.ToString()));
        Console.WriteLine(newStats.Capitals["Russia"]);
    }
}
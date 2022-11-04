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
    }
}
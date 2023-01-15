using ProtectiveProxy;

namespace Proxy;

internal static class Program
{
    private static void Main()
    {
        RunProtectiveProxy();
        RunPropertyProxy();
        RunValueProxy();
    }

    private static void RunValueProxy()
    {
        Console.WriteLine(10m * 5.Percent());
        Console.WriteLine(2.Percent() + 3m.Percent());
    }

    private static void RunPropertyProxy()
    {
        var c = new Creature();
        c.Speed = 12;
    }

    private static void RunProtectiveProxy()
    {
        ICar car = new CarProxy(new Driver(1));
        car.Move();
    }
}
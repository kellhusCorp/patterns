using NullObject.Interfaces;

namespace NullObject.Common;

public class ConsoleLog : ILog
{
    public void Info(string message)
    {
        Console.WriteLine($"[{nameof(Info)}] " + message);
    }

    public void Warn(string message)
    {
        Console.WriteLine($"[{nameof(Warn)}] " + message);
    }
}
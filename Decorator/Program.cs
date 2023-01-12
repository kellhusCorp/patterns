using Decorator.Entities;

namespace Decorator;

static class DecoratorExample
{
    static void Main()
    {
        var cb = new CodeBuilder();
        cb.AppendLine("public class CodeBuilder");
        cb.AppendLine("{");
        cb.AppendLine("}");

        Console.WriteLine(cb);
    }
}
using RuntimeStrategy;
using Strategies.Shared.Enums;

public class Demo
{
    static void Main()
    {
        var tp = new TextProcessor();
        tp.SetOutputFormat(OutputFormat.Markdown);
        tp.AppendList(new[] {"foo", "bar", "bax"});
        Console.WriteLine(tp);
        tp.Clear();
        tp.SetOutputFormat(OutputFormat.Html);
        tp.AppendList(new[] {"foo", "bar", "bax"});
        Console.WriteLine(tp);
    }
}
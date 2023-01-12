using StaticStrategy;
using Strategies.Shared;

public class Demo
{
    static void Main()
    {
        var tp = new TextProcessor<MarkdownListStrategy>();
        tp.AppendList(new[] {"foo", "bar", "bax"});
        Console.WriteLine(tp);

        var tp2 = new TextProcessor<HtmlListStrategy>();
        tp2.AppendList(new[] {"foo", "bar", "bax"});
        Console.WriteLine(tp2);
    }
}
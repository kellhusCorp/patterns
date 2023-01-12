using System.Text;
using Strategies.Shared;
using Strategies.Shared.Enums;
using Strategies.Shared.Interfaces;

namespace RuntimeStrategy;

internal class TextProcessor
{
    private StringBuilder sb = new StringBuilder();

    private IListStrategy listStrategy;

    public void SetOutputFormat(OutputFormat format)
    {
        listStrategy = format switch
        {
            OutputFormat.Markdown => new MarkdownListStrategy(),
            OutputFormat.Html => new HtmlListStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
        };
    }

    public StringBuilder Clear()
    {
        return sb.Clear();
    }

    public override string ToString()
    {
        return sb.ToString();
    }

    public void AppendList(IEnumerable<string> items)
    {
        listStrategy.Start(sb);

        foreach (var item in items)
        {
            listStrategy.AddListItem(sb, item);
        }
        
        listStrategy.End(sb);
    }
}
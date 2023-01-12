using System.Text;
using Strategies.Shared.Interfaces;

namespace StaticStrategy;

internal class TextProcessor<TStrategy>
    where TStrategy : IListStrategy, new()
{
    private StringBuilder sb = new();

    private TStrategy listStrategy = new();

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
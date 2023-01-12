using System.Text;
using Strategies.Shared.Interfaces;

namespace Strategies.Shared;

public class MarkdownListStrategy : IListStrategy
{
    public void Start(StringBuilder sb)
    {
        
    }

    public void End(StringBuilder sb)
    {
        
    }

    public void AddListItem(StringBuilder sb, string item)
    {
        sb.AppendLine($" * {item}");
    }
}
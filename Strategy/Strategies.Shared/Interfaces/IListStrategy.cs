using System.Text;

namespace Strategies.Shared.Interfaces;

public interface IListStrategy
{
    void Start(StringBuilder sb);

    void End(StringBuilder sb);

    void AddListItem(StringBuilder sb, string item);
}
using DI.Interfaces;

namespace DI.Common;

/// <summary>
/// High level module.
/// </summary>
public class Research
{
    public Research(IRelationshipBrowser relationshipBrowser)
    {
        foreach (var childDocument in relationshipBrowser.FindAllChildrenOf("FirstDocument"))
        {
            Console.WriteLine($"У FirstDocument есть дочерний документ {childDocument.Name}");
        }
    }
}
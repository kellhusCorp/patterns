using DI.Entities;

namespace DI.Interfaces;

/// <summary>
/// Solution problem.
/// </summary>
public interface IRelationshipBrowser
{
    IEnumerable<Document> FindAllChildrenOf(string name);
}
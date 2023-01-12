using DI.Entities;
using DI.Enums;
using DI.Interfaces;

namespace DI.Common;

/// <summary>
/// Low level module.
/// </summary>
public class Relationships : IRelationshipBrowser
{
    private readonly List<(Document parent, RelationTypeDocument typeRelation, Document child)> _relations = new();

    public void AddDocumentAndChild(Document parent, Document child)
    {
        _relations.Add((parent, RelationTypeDocument.Bundle, child));
        _relations.Add((child, RelationTypeDocument.Bundle, parent));
    }

    public IEnumerable<Document> FindAllChildrenOf(string name)
    {
        return _relations.Where(x => x.parent.Name == name && x.typeRelation == RelationTypeDocument.Bundle)
            .Select(r => r.child);
    }
}
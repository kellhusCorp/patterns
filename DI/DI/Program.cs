using DI.Common;
using DI.Entities;

namespace DI;

internal static class Program
{
    private static void Main()
    {
        var parentDocument = new Document("FirstDocument");
        var firstChildDocument = new Document("FirstChildDocumentForFirstDocument");
        var secondChildDocument = new Document("SecondChildDocumentForFirstDocument");

        var relationships = new Relationships();
        relationships.AddDocumentAndChild(parentDocument, firstChildDocument);
        relationships.AddDocumentAndChild(parentDocument, secondChildDocument);

        new Research(relationships);
    }
}
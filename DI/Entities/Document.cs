namespace DI.Entities;

public class Document
{
    public Document(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}
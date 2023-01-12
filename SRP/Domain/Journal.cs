namespace SRP.Domain;

public class Journal
{
    private readonly List<string> entries = new List<string>();

    public void AddEntry(string text)
    {
        entries.Add(text);
    }

    public void RemoveEntry(int index)
    {
        if (index < entries.Count && index > 0)
            entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }

    //bad example
    public void Save(string filename, bool overwrite = false)
    {
        File.WriteAllText(filename, ToString());
    }

    ///bad example
    public void Load(string filename)
    {
    }

    //bad example
    public void Load(Uri uri)
    {
    }
}
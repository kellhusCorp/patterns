using System.Text;

public class Snapshot
{
    public StringBuilder Body { get; }

    public Snapshot(StringBuilder body)
    {
        Body = body;
    }
}
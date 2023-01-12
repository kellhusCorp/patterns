using IRP.Interfaces;

namespace IRP.Entities;

public class Photocopier: IPrinter, IScanner
{
    public void Print(Document d)
    {
        // OK
    }

    public void Scan(Document d)
    {
        // OK
    }
}
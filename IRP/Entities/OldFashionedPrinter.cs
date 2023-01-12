using IRP.Interfaces;

namespace IRP.Entities;

// YAGNI
public class OldFashionedPrinter : IMachine
{
    public void Print(Document d)
    {
        // OK
    }

    public void Fax(Document d)
    {
        // 1 способ решения
        throw new NotImplementedException();
    }

    [Obsolete("Not supported", true)]
    public void Scan(Document d)
    {
        // 2 способ решения
    }
}
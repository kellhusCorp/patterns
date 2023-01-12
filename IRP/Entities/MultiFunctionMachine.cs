using IRP.Interfaces;

namespace IRP.Entities;

// IPrinter, IScanner 
public class MultiFunctionMachine : IMultiFunctionDevice
{
    private IPrinter printer;

    private IScanner scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        this.printer = printer;
        this.scanner = scanner;
    }

    public void Print(Document d)
    {
    }

    public void Scan(Document d)
    {
    }
}
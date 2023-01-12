using IRP.Entities;

namespace IRP.Interfaces;

public interface IPrinter
{
    void Print(Document d);
}

using System;

namespace IRP
{
    public class Document
    {

    }

    // YAGNI

    public interface IMachine
    {
        void Print(Document d);
        void Fax(Document d);
        void Scan(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }

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

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

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

    public interface IMultiFunctionDevice : IPrinter, IScanner
    {
        // IFax
    }

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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

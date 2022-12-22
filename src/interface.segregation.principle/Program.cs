/* Avoid one interface with a plenty of functionalities
 * Prefer to break in a smaller interfaces
 */

public class Program
{
    public class Document { }

    public interface IMachine
    {
        void Sprint(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
    
    /*
     * If OldScanner doesn't scan or fax?
     * avoid unnecessary implementations like " This machine doesn't scan files " 
     */
    public class OldScanner : IMachine
    {
        public void Sprint(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }

        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }
    }
    
    /*--------------------*/
    /* God
     */
    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }
    /*
     * ---------------------
     */

    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMultiFunctionalDevice : IScanner, IPrinter //...
    {
        
    }
    
    // Delegate
    // decorator pattern
    public class MultiFunctionalDevice : IMultiFunctionalDevice
    {
        private  IPrinter _printer;
        private  IScanner _scanner;
        
        public MultiFunctionalDevice(IPrinter printer, IScanner scanner)
        {
            _printer = printer ?? throw new ArgumentNullException(nameof(printer));
            _scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
        }
        
        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }

    public static void Main(string[] args)
    {
        
    }
}
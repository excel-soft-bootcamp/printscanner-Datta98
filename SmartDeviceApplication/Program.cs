using System;

namespace SmartDeviceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer _printerRef = new Printer();
            Scanner _scannerRef = new Scanner();

            PrintManager _printManager = new PrintManager();
            _printManager.PrintDocument(_printerRef);

            ScanManager _scanManager = new ScanManager();
            _scanManager.ScanDocument(_scannerRef);

            PrintScanner _printScanner = new PrintScanner();
            _printManager.PrintDocument(_printScanner);
            _scanManager.ScanDocument(_printScanner);
        }
    }
    //public interface IPrinter
    //{
    //    void Print();
    //}

    public class Printer /*: IPrinter*/
    {
        public void Print() { Console.WriteLine("Print in Action"); }
    }

    public class Scanner
    {
        public void Scan() { Console.WriteLine("Scan In Action"); }

    }


    public class PrintScanner : IPrintManager,IScanManager
    {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
         public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }

    }


    public interface IPrintManager
    {
        void PrintDocument(Printer printer);
    }

    public class PrintManager : IPrintManager
    {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
    }


    public interface IScanManager
    {
        void ScanDocument(Scanner scaner);
    }

    public class ScanManager : IScanManager
    {
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceApplication
{
    public class PrintScanner : IPrintManager, IScanManager
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
}

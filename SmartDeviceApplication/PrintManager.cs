using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceApplication
{
    public class PrintManager : IPrintManager
    {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
    }
}

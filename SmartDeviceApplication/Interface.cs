using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceApplication
{
    public interface IPrintManager
    {
        void PrintDocument(Printer printer);
    }




    public interface IScanManager
    {
        void ScanDocument(Scanner scaner);
    }

}

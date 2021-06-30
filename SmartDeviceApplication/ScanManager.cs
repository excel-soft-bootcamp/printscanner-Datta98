using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceApplication
{
    public class ScanManager : IScanManager
    {
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }
    }

}

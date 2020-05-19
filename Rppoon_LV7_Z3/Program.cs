using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider dataProvider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            dataProvider.Attach(consoleLogger);
            while (true)
            {
                dataProvider.GetCPULoad();
                dataProvider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

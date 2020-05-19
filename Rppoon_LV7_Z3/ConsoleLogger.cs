using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z3
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine(DateTime.Now + "-> CPU Load: " + provider.CPULoad + "RAM Available : " + provider.AvailableRAM);
        }
    }
}

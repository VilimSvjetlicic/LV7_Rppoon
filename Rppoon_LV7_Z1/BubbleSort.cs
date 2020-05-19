using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z1
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        Swap(ref array[sort+1],ref array[sort]);
                    }
                }
            }
        }
    }
}

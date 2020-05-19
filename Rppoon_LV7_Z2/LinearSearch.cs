using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z2
{
    class LinearSearch : SearchStrategy
    {
        public override int Search(double[] array, double searcehedItem)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searcehedItem)
                    return i+1;
            }
            return 0;
        }
    }
}

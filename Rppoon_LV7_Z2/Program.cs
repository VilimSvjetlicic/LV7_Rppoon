using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 6, 9, 3, 2, 6, 4, 3, 4, 7, 9 };
            NumberSequence sequence = new NumberSequence(array);
            LinearSearch linearSearch = new LinearSearch();
            sequence.SetSearchStrategy(linearSearch);
            for (int i = 0; i < 10; i++)
            {
                if (sequence.Search(i)>0)
                    Console.WriteLine("Broj "+i+" se nalazi u nizu na "+sequence.Search(i)+". mjesti.");
                else
                    Console.WriteLine("Broj "+i+" se ne nalazi u nizu.");
            }
        }
    }
}

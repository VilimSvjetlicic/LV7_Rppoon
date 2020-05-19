using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array= { 6, 9, 3, 2, 6, 4, 3, 4, 7, 9};
            BubbleSort bubbleSort = new BubbleSort();
            CombSort combSort = new CombSort();
            SequentialSort sequentialSort = new SequentialSort();

            NumberSequence sequence = new NumberSequence(array);
            sequence.SetSortStrategy(bubbleSort);
            sequence.Sort();
            Console.WriteLine(sequence.ToString());
            sequence.SetSortStrategy(combSort);
            sequence.Sort();
            Console.WriteLine(sequence.ToString());
            sequence.SetSortStrategy(sequentialSort);
            sequence.Sort();
            Console.WriteLine(sequence.ToString());
        }
    }
}

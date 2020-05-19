using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Šegrt Hlapić", 25.99);
            VHS vhs = new VHS("Sam u kući", 15.99);
            DVD dvd = new DVD("Medvjedići dobra srca",DVDType.MOVIE, 17.99);

            BuyVisitor buyVisitor = new BuyVisitor();

            Console.WriteLine(book.Accept(buyVisitor));
            Console.WriteLine(vhs.Accept(buyVisitor));
            Console.WriteLine(dvd.Accept(buyVisitor));
        }
    }
}

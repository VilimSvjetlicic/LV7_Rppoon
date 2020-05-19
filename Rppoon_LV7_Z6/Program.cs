using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Šegrt Hlapić", 25.99);
            VHS vhs = new VHS("Sam u kući", 15.99);
            DVD dvd1 = new DVD("Medvjedići dobra srca", DVDType.MOVIE, 17.99);
            DVD dvd2 = new DVD("Half-Life 3", DVDType.SOFTWARE, 17.99);

            RentVisitor rentVisitor = new RentVisitor();

            Console.WriteLine(book.Accept(rentVisitor));
            Console.WriteLine(vhs.Accept(rentVisitor));
            Console.WriteLine(dvd1.Accept(rentVisitor));
            Console.WriteLine(dvd2.Accept(rentVisitor));
        }
    }
}

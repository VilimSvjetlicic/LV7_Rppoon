using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            RentVisitor rentVisitor= new RentVisitor();
            Cart cart = new Cart();

            Book book = new Book("Šegrt Hlapić", 25.99);
            VHS vhs = new VHS("Sam u kući", 15.99);
            DVD dvd1 = new DVD("Medvjedići dobra srca", DVDType.MOVIE, 17.99);
            DVD dvd2 = new DVD("Half-Life 3", DVDType.SOFTWARE, 159.99);

            cart.AddItem(book);
            cart.AddItem(vhs);
            cart.AddItem(dvd1);
            cart.AddItem(dvd2);

            Console.WriteLine(cart.Accept(rentVisitor));

            cart.RemoveItem(dvd2);
            Console.WriteLine(cart.Accept(rentVisitor));
        }
    }
}

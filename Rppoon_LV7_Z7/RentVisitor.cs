using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z7
{
    class RentVisitor : IVisitor
    {
        BuyVisitor buyVisitor = new BuyVisitor();
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
                return Double.NaN;
            else
                return DVDItem.Accept(buyVisitor);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Accept(buyVisitor);
        }
        public double Visit(Book book)
        {
            return book.Accept(buyVisitor);
        }
    }
}

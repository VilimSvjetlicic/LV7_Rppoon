using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z6
{
    class RentVisitor:IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
                return Double.NaN;
            else
                return DVDItem.Price * 0.1;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.1;
        }
        public double Visit(Book book)
        {
            return book.Price * 0.1;
        }
    }
}

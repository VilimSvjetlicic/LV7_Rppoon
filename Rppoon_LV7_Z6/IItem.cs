using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_LV7_Z6
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public interface Store
    {
        Product getProduct(string Name);
        double getDiscount(string loyalty);
    }
}

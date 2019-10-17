using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.creators
{
    class Normal :  Store
    {
        private double discount;
        Normal(string loyalty)
        {
            discount = getDiscount(loyalty);
        }
        private double getDiscount(string loyalty)
        {
            if (loyalty == "stock")
                return 0.2;
            if (loyalty == "client")
                return 0.1;
            if (loyalty == "wholesale")
                return 0.05;
            return 0;
        }
    }
}

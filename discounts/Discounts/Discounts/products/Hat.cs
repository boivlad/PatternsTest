using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.products
{
    class Hat : Product
    {
        private int price;
        Hat(int _price)
        {
            price = _price;
        }
        public string getName()
        {
            return "Шляпа";
        }
        public double getPrice()
        {
            return price;
        }
    }
}

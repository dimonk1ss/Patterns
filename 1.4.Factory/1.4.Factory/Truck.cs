using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4.Factory
{
    internal class Truck : Transport
    {
        public double distance = 73.6;
        public int price_per_kilometr = 2;
        public double SumOfDelivery(int quantity)
        {
            return price_per_kilometr * quantity * distance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4.Factory
{
    public class Plane : Transport
    {
        public double distance = 69.8;
        public int price_per_kilometr = 3;
        public double SumOfDelivery(int quantity)
        {
            return price_per_kilometr * quantity * distance;
        }
    }
}

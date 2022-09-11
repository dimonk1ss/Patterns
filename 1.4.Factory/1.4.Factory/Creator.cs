using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4.Factory
{
    abstract class Creator
    {
 
        public abstract Transport TransportSelection(Transport _transport);
        public string Print(int quantity,Transport _transport)
        {
            var transport = TransportSelection(_transport);
            var result = "Cost of delivery: " + transport.SumOfDelivery(quantity);
            return result;
        }
    }
}

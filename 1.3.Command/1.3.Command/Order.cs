using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Command
{
    public interface Order
    {
        PDV PDV { get; set; }
        BrokerPayment BrokerPayment { get; set; }
        CostControl CostControl { get; set; }

        void excecute();
    }
}

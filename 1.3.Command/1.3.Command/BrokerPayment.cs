using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Command
{
    internal class BrokerPayment : Order
    {
        private Podatok _podatok = new Podatok("Broker Payment",100);
        public BrokerPayment(Podatok podatok)
        {
            _podatok = podatok;
        }



        public void excecute()
        {
            _podatok.PayBroker();  //виконуємо команду покупки товару
        }
    }
}

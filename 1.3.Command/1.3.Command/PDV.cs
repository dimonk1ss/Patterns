using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Command
{
    public class PDV : Order
    {

        private Podatok _podatok ;
        public PDV(Podatok podatok)
        {
            this._podatok = podatok;
        }

        

        public void excecute()
        {
            _podatok.PayPDV();  //виконуємо команду покупки товару
        }
    }
}

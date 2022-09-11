using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Command
{
    public class Podatok
    {
        private String name = " ";
        private int price = 0;
        public Podatok() { }

        public Podatok(string name, int quantity)
        {
            this.name = name;
            this.price = quantity;
        }

        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        internal Program Program1
        {
            get => default;
            set
            {
            }
        }

        public void PayPDV()
        {
            Console.WriteLine("Податок на додану вартість становить 17% з вас: " + Convert.ToDouble(price) * 0.17 + ".");
        }
        public void PayBroker()
        {
            Console.WriteLine("Витрати на брокера становлять 4% з вас: " + Convert.ToDouble(price) * 0.07 + ".");
        }

    }
}

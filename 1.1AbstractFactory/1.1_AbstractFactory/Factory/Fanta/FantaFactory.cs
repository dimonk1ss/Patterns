using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._1_AbstractFactory.Abstract;

namespace _1._1_AbstractFactory.Factory.Fanta
{
    internal class FantaFactory : AbstractFactory
    {
        public override Cap CreateCap()
        {
            return new FantaCap();
        }
        public override Bottle CreateBottle()
        {
            return new FantaBottle();
        }
        public override Drink CreateDrink()
        {
            return new FantaDrink();
        }
    }
}

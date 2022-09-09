using System;
using _1._1_AbstractFactory.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_AbstractFactory.Factory.CocaCola
{
    public class ColaFactory : AbstractFactory
    {
        public override Cap CreateCap()
        {
            return new ColaCap();
        }
        public override Bottle CreateBottle()
        {
            return new ColaBottle();
        }
        public override Drink CreateDrink()
        {
            return new ColaDrink();
        }
    }
}

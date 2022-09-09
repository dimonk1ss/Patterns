using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_AbstractFactory.Abstract
{
    public abstract class AbstractFactory
    {
        public abstract Bottle CreateBottle();
        public abstract Cap CreateCap();
        public abstract Drink CreateDrink();
    }
}

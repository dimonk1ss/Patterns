using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Builder
{
    public abstract class HouseBuilder
    {
        protected House house;
        // Gets vehicle instance
        public House House
        {
            get { return house; }
        }
        // Abstract build methods
        public abstract void BuildRoof(); //Частини
        public abstract void BuildFundament(); //Двигун
        public abstract void BuildFloors(); //Колеса
        
    }
}

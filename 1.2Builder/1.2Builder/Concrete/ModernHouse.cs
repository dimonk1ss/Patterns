using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Builder.Concrete
{
    internal class ModernHouse : HouseBuilder
    {
        public ModernHouse()
        {
            house = new House("Modern House");
        }
        public override void BuildRoof()
        {
            house["roof"] = "Plastik";
        }
        public override void BuildFundament()
        {
            house["fundament"] = "Concrate";
        }
        public override void BuildFloors()
        {
            house["floors"] = "6";
        }

    }
}

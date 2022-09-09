using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Builder.Concrete
{
    internal class FusionHouse : HouseBuilder
    {
        public FusionHouse()
        {
            house = new House("Fusion House");
        }
        public override void BuildRoof()
        {
            house["roof"] = "Marble";
        }
        public override void BuildFundament()
        {
            house["fundament"] = "Iron";
        }
        public override void BuildFloors()
        {
            house["floors"] = "10";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Builder.Concrete
{
    internal class GothicHouse : HouseBuilder
    {
        public GothicHouse()
        {
            house = new House("Gothic House");
        }
        public override void BuildRoof()
        {
            house["roof"] = "Wood";
        }
        public override void BuildFundament()
        {
            house["fundament"] = "Cooblestone";
        }
        public override void BuildFloors()
        {
            house["floors"] = "3";
        }
    }
}

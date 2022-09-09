using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Builder.Concrete
{
    internal class Shop
    {
        public void Construct(HouseBuilder houseBuilder)
        {
            houseBuilder.BuildRoof();
            houseBuilder.BuildFundament();
            houseBuilder.BuildFloors();
            
        }
    }
}

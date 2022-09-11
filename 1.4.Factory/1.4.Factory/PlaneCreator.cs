using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4.Factory
{
    internal class PlaneCreator : Creator
    {
        public override Transport TransportSelection(Transport plane)
        {
            plane = new Plane();
            return plane;
        }
    }
}

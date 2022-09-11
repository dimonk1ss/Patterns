using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4.Factory
{
    internal class TrackCreator : Creator
    {
        public override Transport TransportSelection(Transport transport)
        {
            transport = new Truck();
            return transport;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Builder
{
    public class House
    {
        
        private string _houseType;
        
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();
       
        public House(string vehicleType)
        {
            this._houseType = vehicleType;
        }
        
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("House Type: {0}", _houseType);
            Console.WriteLine(" Roof : {0}", _parts["roof"]);
            Console.WriteLine(" Fundament : {0}", _parts["fundament"]);
            Console.WriteLine(" Floors : {0}", _parts["floors"]);

        }
    }
}

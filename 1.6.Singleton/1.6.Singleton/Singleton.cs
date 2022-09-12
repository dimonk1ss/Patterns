using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._6.Singleton.data;
namespace _1._6.Singleton
{
    
   
        public sealed class Singletone
        {
            private static MyFileDatabase _instance = null;

            private Singletone() { }

            public static MyFileDatabase GetInstance()
            {
                //if (_instance == null) { _instance = new MyFileDatabase(); }
                _instance ??= new MyFileDatabase();
                return _instance;
            }
        }
   
}

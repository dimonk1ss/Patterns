using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5Prototype
{

    public class Person
    {
        
        public IdInfo Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sername { get; set; } 
        public string Diagnoz { get; set; }
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
           
            clone.Id = new IdInfo(Id.IdNumber);
            clone.Name = String.Copy(Name);

            return clone;
        }
    }
}

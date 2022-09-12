using System;

namespace _1._5Prototype
{

    class Program
    {

        static void Main(string[] args)
        {
            
            Person p1 = new Person();
            p1.Age = 18;
            p1.Name = "Nicolas";
            p1.Sername = "Keij";
            p1.Diagnoz = "Cancer";
            p1.Id = new IdInfo(666);
            Person p2 = p1.ShallowCopy();
            
            Person p3 = p1.DeepCopy();

            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Sername: " + p.Sername);
            Console.WriteLine("Diagnoz: " + p.Diagnoz);
            Console.WriteLine("Age: " + p.Age);
            Console.WriteLine("Id: " + p.Id.IdNumber);
        }
    }
}


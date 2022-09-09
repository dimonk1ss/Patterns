using System;
using _1._1_AbstractFactory.Abstract;
using _1._1_AbstractFactory.Factory.CocaCola;
using _1._1_AbstractFactory.Factory.Fanta;
namespace _1._1_AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose fabric (f - Fanta,c-CocaCola)");
            char input = Console.ReadKey().KeyChar;
            AbstractFactory factory;
            switch (input)
            {
                case 'f':
                    factory = new FantaFactory();
                    break;

                case 'c':
                    factory = new ColaFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            
            Bottle bottle = factory.CreateBottle(); 
            var cap = factory.CreateCap(); 
            var drink = factory.CreateDrink();
            Console.WriteLine("\nWhich quantity of drinks you want to order??");
            int quantity = Convert.ToInt32(Console.ReadLine());
            long cost_of_purchase = quantity * (bottle.Price+cap.Price+drink.Price);
            Console.WriteLine("\t\tBill of sale\t\t\nBottle x " + quantity* bottle.Price + "\nCap x " + quantity * cap.Price + "\nDrink x " + quantity * drink.Price + "\nCost: " + cost_of_purchase); 
            Console.ReadKey();
        }
    }
    



}

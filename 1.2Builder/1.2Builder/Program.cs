using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._2Builder.Concrete;
namespace _1._2Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();
            Console.WriteLine("What type of house you want: 1-Fusion,2-Gothic,3-Modern");
            int action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:
                    builder = new FusionHouse();
                    break;
                case 2:
                    builder = new GothicHouse();
                    break;
                default:
                    builder = new ModernHouse();
                    break;
            }

            shop.Construct(builder);
            builder.House.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
}

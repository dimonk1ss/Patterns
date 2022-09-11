using System;
namespace _1._4.Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company \"Rivne-Lutsk Delivery\"  welcomes you! What type of delivery you want to choose: ");
            Console.WriteLine("truck - for truck delivery");
            Console.WriteLine("plane - for plane delivery");
            string a = Console.ReadLine();
            Console.WriteLine("Insert how many transport you need to deliver your delivery: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            string res = " ";
            if(a == "truck")
            {
                Transport truck = new Truck();

                Creator creator = new TrackCreator();
                 res = creator.Print(quantity, truck);
            }
            if(a == "plane")
            {
                Transport truck = new Plane();

                Creator creator = new PlaneCreator();
                 res = creator.Print(quantity, truck);

            }
            Console.WriteLine(res);
        }
    }
}

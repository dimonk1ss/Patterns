using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Паттерн команд!");
            Podatok audiQuery = new Podatok("Audi 3.0", 1000);
            //Створюємо команди
            PDV buyQuery = new PDV(audiQuery);
            
            BrokerPayment sellQuery = new BrokerPayment(audiQuery);

            CostControl broker = new CostControl();
            broker.TakeOrder(buyQuery);
            broker.TakeOrder(sellQuery);

            //виконати команди для брокера
            broker.PlaceOrders();

        }
    }
}

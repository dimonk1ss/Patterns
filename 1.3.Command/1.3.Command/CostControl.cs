using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Command
{
    public class CostControl : Order
    {
        private List<Order> _orders = new List<Order>();

        public Order Order
        {
            get => default;
            set
            {
            }
        }

        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        internal Program Program1
        {
            get => default;
            set
            {
            }
        }

        public void TakeOrder(Order order)
        {
            //Додаємо команду
            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (Order order in _orders)
            {
                order.excecute(); //Виконуємо команди
            }
            //Очисчаємо список комнад
            _orders.Clear();
        }

        public void excecute()
        {
            throw new NotImplementedException();
        }
    }
}

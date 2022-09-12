using System;
using _1._6.Singleton.data;
namespace _1._6.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію");
                Console.WriteLine("0. Мене не цікавлять машини");
                Console.WriteLine("1. Показати машини");
                Console.WriteLine("2. Додати машину");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            var myDb = Singletone.GetInstance();
                            TypedReference tr = __makeref(myDb);
                            Console.WriteLine("myDb address = {0}", tr.GetHashCode());
                            foreach (var item in myDb.Persons)
                            {
                                Console.WriteLine("Name: " + item.Name);
                            }
                        }
                        break;
                    case 2:
                        {
                            Person girl = new Person()
                            {
                                Age = 20,
                                Hair = "Біло-Рижа",
                                Weight = 85
                            };
                            //Console.WriteLine("Адреса дівчини {0}", __makeref(girl).GetHashCode());
                            Console.WriteLine("Ім'я:");
                            girl.Name = Console.ReadLine();
                            var myDb = Singletone.GetInstance();
                            TypedReference tr = __makeref(myDb);
                            Console.WriteLine("myDb address = {0}", tr.GetHashCode());
                            myDb.Persons.Add(girl);
                            myDb.SaveChanges();
                        }
                        break;
                }
            } while (action != 0);

        }
    }
}

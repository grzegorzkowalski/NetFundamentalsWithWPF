using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class OrderService
    {
        private OrdersRepository _orderRepository;
        internal OrderService(OrdersRepository repository)
        {
            _orderRepository = repository;
        }

        internal void PlaceOrder()
        {
            var order = new Order();
            var command = "";
            while (!command.Equals("end"))
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("add - dodaj pozycje do zamowienia");
                Console.WriteLine("end - zamknij zamowienie");

                command = Console.ReadLine();
                if (command.Equals("add"))
                {
                    Console.WriteLine("Podaj Id książki");
                    var orderId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj ilość");
                    var count = Convert.ToInt32(Console.ReadLine());
                    var repository = new BooksRepository();                
                    if (repository.GetAll().Exists(s => s.ISBN.Equals(orderId)) 
                        && repository.GetAll().Count() < order.BooksOrderList.Count)
                    {
                        order.BooksOrderList.Add(new BookOrdered()
                        {
                            BookId = orderId,
                            NumberOrdered = count
                        });
                    }
                }
            }
        }

        internal void ListAll()
        {
            foreach (var item in _orderRepository.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

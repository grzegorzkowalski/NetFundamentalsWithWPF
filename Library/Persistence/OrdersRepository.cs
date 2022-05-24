using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class OrdersRepository : BaseRepository<Order>
    {
        private List<Order> database = new List<Order>();

        //public void Insert(Order order)
        //{
        //    database.Add(order);
        //}

        //public List<Order> GetAll()
        //{
        //    return database;
        //}
    }
}

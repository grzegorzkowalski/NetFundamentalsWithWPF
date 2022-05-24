using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class BaseRepository<T> where T : IModel
    {
        protected List<T> Database = new List<T>();
        protected int Counter;

        public void Insert(T element)
        {
            element.Id = Counter++;
            Database.Add(element);
        }

        public void Remove(T element)
        {
            Database.Remove(element);
        }

        public void RemoveById(int id)
        {
            var element = Database[id];
            Database.Remove(element);
        }

        public List<T> GetAll()
        {
            return Database;
        }

        public virtual T GetById(int id)
        {
            return Database.First(s => s.Id == id);
        }
    }
}

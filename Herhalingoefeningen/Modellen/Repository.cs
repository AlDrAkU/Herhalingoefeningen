using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingoefeningen.Modellen
{
    internal class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public List<T> GetAll()
        {
            return items;
        }
    }
}

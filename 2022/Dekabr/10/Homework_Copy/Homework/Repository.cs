using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Repository<T>
    {
        public List<T> DataSource = new List<T>();

        public virtual List<T> Get()
        {
            return null;
        }

        public virtual void Add(T data)
        {
            DataSource.Add(data);
            Console.WriteLine("Data elave olundu.");
        }

        public virtual void Uptade(T data)
        {
            if (DataSource.Contains(data))
            {
                DataSource[DataSource.IndexOf(data)] = data;
            }
        }

        public virtual void Delete(T data)
        {
            if (DataSource.Contains(data))
            {
                DataSource.Remove(data);
            }
        }

        public virtual void Show()
        {
            DataSource.ForEach(a => Console.WriteLine(a));
        }

    }
}

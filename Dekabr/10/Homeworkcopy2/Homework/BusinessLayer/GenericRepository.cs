using Homework.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.BusinessLayer
{
    public class GenericRepository<T>
    {
        public virtual T Get(int id)
        {
            return default(T);
        }

        public virtual List<T> GetAll()
        {
            return new List<T>();
        }

        public virtual void Add(T data)
        {
            
        }

        public virtual void Update(T data)
        {
            
        }

        public virtual void Delete(T data)
        {
            
        }
    }
}

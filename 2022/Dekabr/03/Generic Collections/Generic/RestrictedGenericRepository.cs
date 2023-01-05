using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class RestrictedGenericRepository<T> where T : class //Hansı ki, T bir class'dır.
    {
        public virtual T Get(T id)
        {
            return id;
        }

        public virtual List<T> GetAll()
        {
            return null;
        }

        public virtual void Update(T data)
        {

        }

        public virtual int Delete(T data)
        {
            return 1;
        }
    }
}

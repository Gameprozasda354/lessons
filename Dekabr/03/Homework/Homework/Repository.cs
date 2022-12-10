using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Repository<A>
    {
        List<A> Data = new List<A>();

        public virtual List<A> Get()
        {
            return null;
        }

        public virtual void Add(A data)
        {
            Data.Add(data);
            Console.WriteLine("Data elave olundu.");
        }

        public virtual void Add(A data)
        {
            Data.Add(data);
            Console.WriteLine("Data elave olundu.");
        }

        public virtual void Show()
        {
            Data.ForEach(a => Console.WriteLine(a));
        }

    }
}

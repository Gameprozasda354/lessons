using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Customer<A, B>
    {
        public A Name { get; set; }
        public A Surname { get; set; }
        public B Age { get; set; }
        public A Order { get; set; }
    }
}

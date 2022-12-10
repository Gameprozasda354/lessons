using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Teacher<A, B>
    {
        public A Name { get; set; }
        public A SurName { get; set; }
        public A Science { get; set; }
        public B Age { get; set; }
    }
}

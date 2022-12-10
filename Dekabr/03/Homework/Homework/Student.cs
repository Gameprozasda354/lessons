using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Student<A, B>
    {
        public A Name { get; set; }
        public A SurName { get; set; }
        public B Age { get; set; }
        
    }
}

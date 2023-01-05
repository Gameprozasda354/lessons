using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Book<A, B>
    {
        public A Name { get; set; }
        public B CreateYear { get; set; }
    }
}

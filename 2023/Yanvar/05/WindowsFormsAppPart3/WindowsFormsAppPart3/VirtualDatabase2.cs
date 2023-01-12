using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart3
{
    internal class VirtualDatabase2 
    {
        public static List<Customer2> Customers { get; set; }

        static VirtualDatabase2()
        {
            Customers = new List<Customer2>();
        }
    }
}

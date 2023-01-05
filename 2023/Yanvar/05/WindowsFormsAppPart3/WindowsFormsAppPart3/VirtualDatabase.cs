using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart3
{
    public class VirtualDatabase
    {
        public static List<Customer> Customers { get; set; }

        static VirtualDatabase()
        {
            Customers = new List<Customer>();
        }
    }
}

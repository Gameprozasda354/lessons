using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Order
    {
        public int Id { get; set; }
        public string OrderDetails { get; set; }
        public Address ShippingAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

    }
}

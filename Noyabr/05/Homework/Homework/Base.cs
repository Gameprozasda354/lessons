using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Base
    {
        public int Id { get; }
        public int BarCode { get; set; }
        public string Model { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int OfferPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public string CreateUser { get; set; }
        public string EditUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
        public string DeleteUser { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    internal class TransferPeriod
    {
        public int TransferID { get; set; }
        public DateTime FromDate { get; set; }
        public int ToDate { get; set; }
        TransferType transferType;
        public int Price { get; set; }
        public int Total { get; set; }

    }
}

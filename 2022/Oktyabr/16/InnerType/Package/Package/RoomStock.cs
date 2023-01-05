using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package
{
    internal class RoomStock
    {
        public string RoomStockID { get; set; }

        RoomType roomType;

        public int Stock { get; set; }
        public int RoomStockPrice { get; set; }

        HotelPrice hotelPrice;
       

    }
}

using System;

namespace InnerType
{
    public class Address
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Distinct { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        //Inner Type field
        public City City;
    }
}

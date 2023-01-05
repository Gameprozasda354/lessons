using System;

namespace InnerType
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        //Inner Type field
        public Country Country;
    }
}

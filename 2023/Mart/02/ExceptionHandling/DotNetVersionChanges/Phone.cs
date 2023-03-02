using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVersionChanges
{
    public class Phone
    {
        //Not Auto Property
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        //Auto Property
        public string Model { get; set; }

        public const string SomeProperty = "Some value";

        public string SomeAutoProp { get; } = SomeProperty;
    }
}

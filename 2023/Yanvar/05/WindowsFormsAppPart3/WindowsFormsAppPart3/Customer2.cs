using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart3
{
    internal class Customer2 : Customer
    {
        public string City { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + FatherName + " " + Email + " " + PhoneNumber + " " + City;
        }
    }
}

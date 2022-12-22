using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string OrderName { get; set; }
        public Customer(string name, string surname, int age, string orderName)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.OrderName = orderName;
        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + Age + " " + OrderName;
        }
    }
}

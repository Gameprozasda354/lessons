using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string MaleOrFemale { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Student
    {
        public string Name(string name, string surName)
        {
            string b = "";
            if(name.Length + surName.Length < 20)
            {
                b = name + " " + surName;
            }

            else
            {
                b = name[0] + ". " + surName;
            }

            return b;
        }

    }
}

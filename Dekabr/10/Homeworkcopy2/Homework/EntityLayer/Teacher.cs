using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.EntityLayer
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Science { get; set; }
        public int Age { get; set; }
        public Teacher(string name, string surname, int age, string science)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Science = science;
        }
    }
}

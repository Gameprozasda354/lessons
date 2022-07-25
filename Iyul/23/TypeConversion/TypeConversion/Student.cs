using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        //User-Defined Conversion olan hisse
        public static implicit operator string(Student s) => s.Name + " " + s.Surname + " " + s.Age;

        public override string ToString() => Name + " " + Surname + " " + Age;
    }
}

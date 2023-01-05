using System;

namespace Static
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public void Test()
        {
            Console.WriteLine("Bu methodu istifade etmek ucun Student class'inin instance'i yaradilmalidir!");
        }

        public static void Test1()
        {
            Console.WriteLine("Bu methodu istifade etmek ucun Student class'inin instance'i YARADILMAMALIDIR!");
        }
    }
}

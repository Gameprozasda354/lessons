using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] names = new string[] { "Omer", "Orkhan", "Eli", "Veli", "Bayram", "Xaliq", "Ferid" };
            Random random = new Random();
            for (int i = 0; i < names.Length; i++)
            {
                Student student = new Student()
                {
                    Id = i + 1,
                    Name = names[i],
                    Age = random.Next(18, 50)
                };

                students.Add(student);
            }
            bool biggerThan25 = students.Any(i => i.Age > 25);
            if (biggerThan25)
            {
                students.RemoveAll(i => i.Age > 25);
                Console.WriteLine("Telebeler silindi.");
            }
        }
    }
}

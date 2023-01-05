using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Book> bookRepository = new Repository<Book>();
            bookRepository.Add(new Book("Harry Potter", 2010));
            bookRepository.Show();

            Repository<Customer> customerRepository = new Repository<Customer>();
            customerRepository.Add(new Customer("Orkhan", "Farajov", 25, "Laptop"));
            customerRepository.Show();

            Repository<Student> studentRepository = new Repository<Student>();
            studentRepository.Add(new Student("Orkhan", "Farajov", 25));
            studentRepository.Show();

            Repository<Teacher> teacherRepository = new Repository<Teacher>();
            teacherRepository.Add(new Teacher("Orkhan", "Farajov", 25, "Computer"));
            teacherRepository.Show();

            Console.Read();
        }
    }
}

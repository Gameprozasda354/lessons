using Homework.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataLayer
{
    public static class Database
    {
        public static List<Customer> CustomerTable = new List<Customer>();
        public static List<Student> StudentTable = new List<Student>();
        public static List<Teacher> TeacherTable = new List<Teacher>();
        public static List<Book> BookTable = new List<Book>();
    }
}

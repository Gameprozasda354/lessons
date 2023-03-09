using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson1
{
    internal class DataBase
    {
        public List<Customer> customerList = new List<Customer>();

        public List<Customer> TheLetter(char a)
        {
            return customerList.FindAll(x => x.Name[0]==a);
        }
        public List<Customer> TheAge(int a, int b)
        {
            return customerList.FindAll(x => x.Age >= a && x.Age <= b);
        }
    }
}

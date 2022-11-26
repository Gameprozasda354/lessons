using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int BornDate { get; set; }
        public int DeadDate { get; set; }

        public Writer()
        {
            DataBase.Id += 1;
        }
    }
}

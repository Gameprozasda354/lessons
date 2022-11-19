using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Writer : Category
    { 
    
        public string SurName { get; set; }
        public DateTime BornDate  { get; set; }
        public DateTime DeadDate { get; set; }

        public Writer()
        {
            DataBase.Id += 1;
        }
    }
}

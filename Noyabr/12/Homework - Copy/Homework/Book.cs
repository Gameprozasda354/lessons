using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Book : Category
    {
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        public Book()
        {
            DataBase.Id += 1;
        }
    }
}

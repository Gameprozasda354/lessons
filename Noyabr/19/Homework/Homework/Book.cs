using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Book
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public int CoverId { get; set; }
        public Book()
        {
            DataBase.Id += 1;
        }
    }
}

using Homework.BusinessLayer;
using Homework.EntityLayer;
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
            BookBusiness bookBusiness = new BookBusiness();
            Book harryPotter = new Book("Harry Potter", 2010);

            bookBusiness.Add(harryPotter);
            var book = bookBusiness.Get(1);

            var allBooks = bookBusiness.GetAll();

            book.CreateYear = 2009;

            bookBusiness.Update(book);

            var byBookName = bookBusiness.GetByBookName("Harry Potter");

            bookBusiness.Delete(book);
            Console.Read();
        }
    }
}

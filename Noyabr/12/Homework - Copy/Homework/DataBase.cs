using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class DataBase
    {
        public static int Id = 1;
        public ArrayList Writers = new ArrayList();
        public ArrayList Categories = new ArrayList();
        public ArrayList Books = new ArrayList();

        public void ShowMenu()
        {
            Console.WriteLine("1-Kitab elave edin.");
            Console.WriteLine("2-Kitablari goster.");
            Console.WriteLine("3-Kitabın  parametrlerini deyis.");
            Console.WriteLine("4-Kitabi sil.");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    ShowBooks();
                    break;
                case 3:
                    UpdateBook();
                    break;
                case 4:
                    DeleteBook();
                    break;
            }
        }
        public void AddBook()
        {

            Console.WriteLine("Kitabin adini daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Kitabin yazicisini daxil edin:");

            foreach (Writer item in Writers)
            {
                Console.WriteLine("{0}-{1} {2}({3}-{4})", item.Id, item.Name, item.SurName, item.BornDate.Year,
                    item.DeadDate.Year);
            }

            int authorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitabin kategoriyasini secin ve daxil edin.");
            foreach (Category item in Categories)
            {
                Console.WriteLine("{0}-{1}", item.Id, item.Name);
            }
            int categoryId = Convert.ToInt32(Console.ReadLine());

            Books.Add(new Book()
            {
                Id = Id,
                Name = name,
                AuthorId = authorId,
                CategoryId = categoryId,
            });

            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }

        public void ShowBooks()
        {
            int a = 1;
            foreach(Book book in Books)
            {
                Console.WriteLine("{0}.{1} CategoryId:{2} AuthorId:{3}", a, book.Name, book.CategoryId, book.AuthorId);
                a++;
            }
            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void UpdateBook()
        {
            Console.WriteLine("Kitabin adini daxil edin:");
            var name = Console.ReadLine();
            bool contains = false;
            foreach(Book book in Books)
            {
                if (book.Name == name)
                {
                    Console.WriteLine("Kitabin adini ne ile evezlemek isteyirsiniz?");
                    book.Name = Console.ReadLine();
                    contains = true;
                }
            }
            if (contains != true)
                Console.WriteLine("Kitab tapilmadi.");

            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void DeleteBook()
        {
            Console.WriteLine("Silmek istediyiniz kitabin adini daxil edin:");
            var name = Console.ReadLine();
            bool contains = false;
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    Books.Remove(book);
                    contains = true;
                    break;
                }
            }
            if (contains != true)
                Console.WriteLine("Kitab tapilmadi.");
            if (!contains)
                Console.WriteLine("Kitab tapilmadi.");

            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }

    }
}

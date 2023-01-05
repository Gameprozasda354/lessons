using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class DataBase
    {


        public Writer[] Writers;
        public Category[] Categories;
        public Book[] Books;

        public DataBase()
        {
            Writers = new Writer[2];
            Categories = new Category[2];
            Books = new Book[100];
        }
        public void ShowMenu()
        {
            Console.WriteLine("1-Kitab elave edin:");
            Console.WriteLine("2-Kitablari gosterş");
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
            int count = 0;
            foreach(var book in Books)
            {
                if(book!=null)
                {
                    count = count + 1;
                }
            }

            int id = count + 1; 
            Console.WriteLine("Kitabin adini daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Kitabin yazicisini daxil edin:");
            for(int i = 0; i < Writers.Length; i++)
            {
                Console.WriteLine("{0}-{1} {2}({3}-{4})",Writers[i].Id, Writers[i].Name, Writers[i].SurName, Writers[i].BornDate.Year,
                    Writers[i].DeadDate.Year);
            }
            int authorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitabin kategoriyasini secin ve daxil edin.");
            for (int i = 0; i < Categories.Length; i++)
            {
                Console.WriteLine("{0}-{1}" , Categories[i].Id, Categories[i].Name);
            }
            int categoryId = Convert.ToInt32(Console.ReadLine());

            Books[count] = new Book()
            {
                Id = id,
                Name = name,
                AuthorId = authorId,
                CategoryId = categoryId,
            };
            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }

        public void ShowBooks()
        {
            int count = 0;
            foreach (var book in Books)
            {
                if (book != null)
                {
                    count = count + 1;
                }
            }
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}.{1} CategoryId:{2} AuthorId:{3}", Books[i].Id, Books[i].Name, Books[i].CategoryId, Books[i].CategoryId);
            }
            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void UpdateBook()
        {
            int count = 0;
            foreach (var book in Books)
            {
                if (book != null)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine("Kitabin adini daxil edin:");
            var name = Console.ReadLine();
            int number = 0;
            bool contains = false;
            for(int i = 0; i < count; i++)
            {
                if (Books[i].Name == name)
                {
                    number = i;
                    contains = true;
                }
            }
            if (contains == true)
            {
                Console.WriteLine("Kitabin adini ne ile evezlemek isteyirsiniz?");
                Books[number].Name = Console.ReadLine();
            }
            else
                Console.WriteLine("Kitab tapilmadi.");
            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void DeleteBook()
        {
            int count = 0;
            foreach (var book in Books)
            {
                if (book != null)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine("Silmek istediyiniz kitabin adini daxil edin:");
            var name = Console.ReadLine();
            int number = 0;
            bool contains = false;
            for (int i = 0; i < count; i++)
            {
                if (Books[i].Name == name)
                {
                    number = i;
                    contains = true;
                }
            }
            if (contains == true)
            {
                Books[number] = null;
            }
            else
                Console.WriteLine("Kitab tapilmadi.");

            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }

    }
}

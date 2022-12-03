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
        public string WriteroBook = "Book";
        public ArrayList Writers = new ArrayList();
        public ArrayList Books = new ArrayList();
        public ArrayList Categories = new ArrayList();
        public ArrayList CoverTypes = new ArrayList();

        public void AddingFunction()
        {
            Categories.Add(new Category()
            {
                Id = Id,
                Name = "Roman"
            });
            Categories.Add(new Category()
            {
                Id = Id,
                Name = "Efsane"
            });
            Categories.Add(new Category()
            {
                Id = Id,
                Name = "Dastan"
            });
            Categories.Add(new Category()
            {
                Id = Id,
                Name = "Nagil"
            });
        }
        public void ShowMenu()
        {            
            Console.WriteLine("1-Kitab");
            Console.WriteLine("2-Yazici");
            Console.WriteLine("3-Uz qabigi elave etmek.");
            int enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                case 1:
                    Console.Clear();
                    BookMenu();
                    break;
                case 2:
                    Console.Clear();
                    WriterMenu();
                    break;
                case 3:
                    Console.Clear();
                    AddCover();
                    break;
            }
        }
        public void BookMenu()
        {
            Console.WriteLine("1-Kitab elave et.");
            Console.WriteLine("2-Kitablari goster.");
            Console.WriteLine("3-Kitab sil.");
            Console.WriteLine("4-Kitabin parametrlerini deyis.");
            int enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    ShowBooks();
                    break;
                case 3:
                    DeleteBook();
                    break;
                case 4:
                    UpdateBook();
                    break;
            }
        }
        public void WriterMenu()
        {
            Console.WriteLine("1-Yazici elave et.");
            Console.WriteLine("2-Yazicilari goster.");
            Console.WriteLine("3-Yazici sil.");
            Console.WriteLine("4-Yazicinin parametrlerini deyis.");
            int enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                case 1:
                    AddWriter();
                    break;
                case 2:
                    ShowWriters();
                    break;
                case 3:
                    DeleteWriter();
                    break;
                case 4:
                    UpdateWriter();
                    break;
            }
        }
        public void AddBook()
        {

            Console.WriteLine("Kitabin adini daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Kitabin sehife sayini daxil edin.");
            int pageCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitabin yazicisini daxil edin:");

            foreach (Writer item in Writers)
            {
                Console.WriteLine("{0}-{1} {2}({3}-{4})", item.Id, item.Name, item.SurName, item.BornDate,
                    item.DeadDate);
            }

            int authorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitabin kategoriyasini secin ve daxil edin.");
            foreach (Category item in Categories)
            {
                Console.WriteLine("{0}-{1}", item.Id, item.Name);
            }
            int categoryId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kitabin uz qabigini secin ve daxil edin.");
            foreach (CoverType item in CoverTypes)
            {
                Console.WriteLine("{0}-{1}", item.Id, item.Name);
            }
            int coverId = Convert.ToInt32(Console.ReadLine());

            Books.Add(new Book()
            {
                Id = Id,
                Name = name,
                PagesCount = pageCount,
                WriterId = authorId,
                CategoryId = categoryId,
                CoverId = coverId
            });

            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void AddWriter()
        {
            Console.WriteLine("Yazicinin adini daxil edin.");
            string name = Console.ReadLine();
            Console.WriteLine("Yazicinin soyadini daxil edin.");
            string surName = Console.ReadLine();
            Console.WriteLine("Yazicinin dogum ilini daxil edin.");
            string bornDate = Console.ReadLine();
            Console.WriteLine("Yazicinin olum ilini daxil edin.");
            string deadDate = Console.ReadLine();
            Writers.Add(new Writer()
            {
                Id= Id,
                Name = name,
                SurName = surName,
                BornDate = bornDate,
                DeadDate = deadDate,
            });
            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void AddCover()
        {
            Console.WriteLine("Uz qabiginin adini daxil edin.");
            string name = Console.ReadLine();
            CoverTypes.Add(new CoverType()
            {
                Id = Id,
                Name = name
            });
            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void ShowBooks()
        {
            int a = 1;
            string writerName = "";
            string writerSurName = "";
            string categoryName = "";
            string coverName = "";
            foreach (Book book in Books)
            {
                foreach (Writer writer in Writers)
                {
                    if (writer.Id == book.WriterId)
                    {
                        writerName = writer.Name;
                        writerSurName = writer.SurName;
                    }
                }
                foreach (Category category in Categories)
                {
                    if (category.Id == book.CategoryId)
                    {
                        categoryName = category.Name;
                    }
                }
                foreach (CoverType cover in CoverTypes)
                {
                    if (cover.Id == book.CoverId)
                    {
                        coverName = cover.Name;
                    }
                }

                Console.WriteLine("{0}.{1} Sehifesayi:{2} CategoryId:{3} Writer:{4} {5} CoverId:{6}", a, book.Name,book.PagesCount, categoryName, writerName, writerSurName, coverName);
                a++;
            }
            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void ShowWriters()
        {
            int a = 1;
            foreach (Writer writer in Writers)
            {
                Console.WriteLine("{0}.{1} {2} ({3}-{4})", a, writer.Name, writer.SurName, writer.BornDate, writer.DeadDate);
                a++;
            }
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
        public void DeleteWriter()
        {
            Console.WriteLine("Silmek istediyiniz yazicinin adini daxil edin:");
            var name = Console.ReadLine();
            Console.WriteLine("Silmek istediyiniz yazicinin soyadini daxil edin:");
            var surName = Console.ReadLine();
            bool contains = false;
            bool bookContains = true;
            foreach (Writer writer in Writers)
            {
                if (writer.Name == name && writer.SurName == surName)
                {
                    foreach(Book book in Books)
                    {
                        if(book.WriterId == writer.Id)
                        {
                            bookContains = false;
                        };
                    }
                    if (!bookContains)
                    {
                        Console.WriteLine("Bu yazici siline bilmez.");
                        Console.WriteLine("Silmek ucun ilk once bu kitablar silinmelidir");
                        foreach(Book book in Books)
                        {
                            if (book.WriterId == writer.Id)
                            {
                                Console.WriteLine(book.Name);
                            };
                        }
                        contains = true;
                        break;
                    }
                    else
                    {
                        Writers.Remove(writer);
                        contains = true;
                        Console.WriteLine("Yazici silindi.");
                        break;
                    }

                    break;
                }
            }
            if(contains == false)
                Console.WriteLine("Yazici tapilmadi.");


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
            foreach (Book book in Books)
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
        public void UpdateWriter()
        {
            Console.WriteLine("Editlemek istediyiniz yazicinin adini daxil edin:");
            var name = Console.ReadLine();
            Console.WriteLine("Editlemek istediyiniz yazicinin soyadini daxil edin:");
            var surName = Console.ReadLine();
            bool contains = false;
            foreach (Writer writer in Writers)
            {
                if (writer.Name == name && writer.SurName == surName)
                {
                    contains = true;
                    break;
                }
            }
            Console.WriteLine("1-Yazicinin adini editlemek.");
            Console.WriteLine("2-Yazicinin dogum tarixini editlemek.");
            Console.WriteLine("3-Yazicinin olum tarixini editlemek.");
            int a = Convert.ToInt32(Console.ReadLine());
            foreach (Writer writer in Writers)
            {
                if (writer.Name == name && writer.SurName == surName)
                {
                    if(a == 1)
                    {
                        Console.WriteLine("Yazicinin adini ne ile evezlemek isteyirsiniz?");
                        writer.Name = Console.ReadLine();
                    }
                    else if(a == 2)
                    {
                        Console.WriteLine("Yazicinin dogum tarixini ne ile evezlemek isteyirsiniz?");
                        writer.BornDate = Console.ReadLine();
                    }
                    else if (a == 3)
                    {
                        Console.WriteLine("Yazicinin olum tarixini ne ile evezlemek isteyirsiniz?");
                        writer.DeadDate = Console.ReadLine();
                    }
                    break;
                }
            }


            if (!contains)
                Console.WriteLine("Yazici tapilmadi.");

            Console.WriteLine("Davam etmek ucun entere basin.");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }

    }
}

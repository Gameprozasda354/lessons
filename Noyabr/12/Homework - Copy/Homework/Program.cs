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

            DataBase dataBase = new DataBase();

            Category roman = new Category()
            {
                Id = DataBase.Id,
                Name = "Roman",
            };

            dataBase.Categories.Add(roman);

            Category efsane = new Category()
            {
                Id = DataBase.Id,
                Name = "Əfsanə",
            };

            dataBase.Categories.Add(efsane);

            Writer cm = new Writer()
            {
                Id = DataBase.Id,
                Name = "Cingiz Mustafayev",
                BornDate = DateTime.Now,
                DeadDate = DateTime.Today,
            };

            dataBase.Writers.Add(cm);

            Writer jkr = new Writer()
            {
                Id = DataBase.Id,
                Name = "J.K.Rowling",
                BornDate = DateTime.Now,
                DeadDate = DateTime.Today,
            };

            dataBase.Writers.Add(jkr);

            dataBase.Books.Add(new Book()
            {
                Id = DataBase.Id,
                Name = "HarryPotter",
                AuthorId = jkr.Id,
                CategoryId = efsane.Id,
            });

            dataBase.Books.Add(new Book()
            {
                Id = DataBase.Id,
                Name = "Peter Pen",
                AuthorId = cm.Id,
                CategoryId = roman.Id,
            });

            

            dataBase.ShowMenu();
        }
        /*
        Homework 1:
            Bu gün ev tapşırığınız abstract, interface, virtual method'ları araşdırmaqdır.
            Araşdırandan sonra da, gələn dərsə qədər bir nümunə hazırlamağa çalışın. Bu bir kiçik kitabxana app'ı,
            calculator və ya hər hansısa kiçik bir task ola bilər. Generic collection'ları falan keçəndən sonra
            kiçik app'lar yazanda bunları praktika edəndə daha rahat başa düşəcəksiz çünkü hal-hazırda bunları
            real tədbiq etməyə çalışsaz hələ bilmədiyiniz nə qədər mövzu əksiyi var.
         
         Yazarlar
         1-Cingiz Mustafayev
         2-Paulo Ceolho
         3-Ronda Bryne


         Kateqoriyalar
         1-Roman
         2-Dedektiv
         3-Elmi
         4-Texnologiya


         Kitablar
         1. The Secret (Id:1, Name: The Secret, (int)AuthorId:3, (int)CategoryId:3)


         C-Create
         R-Read
         U-Update
         D-Delete
         */
    }
}

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
            

            dataBase.Books[0] = new Book()
            {
                Id = 1,
                Name = "HarryPotter",
                AuthorId = 1,
                CategoryId = 1,
            };
            dataBase.Books[1] = new Book()
            {
                Id = 2,
                Name = "Peter Pen",
                AuthorId = 2,
                CategoryId = 2,
            };
            dataBase.Writers[0] = new Writer()
            {
                Id = 1,
                Name = "Cingiz Mustafayev",
                BornDate = DateTime.Now,
                DeadDate = DateTime.Today,
            };
            dataBase.Writers[1] = new Writer()
            {
                Id = 2,
                Name = "Paulo Ceolho",
                BornDate = DateTime.Now,
                DeadDate = DateTime.Today,
            };
            dataBase.Categories[0] = new Category()
            {
                Id = 1,
                Name = "Roman",
            };
            dataBase.Categories[1] = new Category()
            {
                Id = 2,
                Name = "Əfsanə",
            };
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

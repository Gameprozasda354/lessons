using MsSQL___Start.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSQL___Start
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Solution of past Homework 1
            /*
             Homework 1:
             public delegate void RunAnyMethod();

             public static void Add(){
                 Console.WriteLine("Add method");
             }

             public static void Edit(){
                 Console.WriteLine("Add method");
             }

             public static void Delete(){
                 Console.WriteLine("Add method");
             }

             Yuxarıda 1 delegate'iniz var və 3 dənə də standart adi method. Elə etməlisiniz ki, məsələn myDelegate adında bir dəyişəniniz olsun və myDelegate dəyişənini
             method kimi istifadə edə biləsiniz. Yəni myDelegate() yazanda bir method işləmiş olsun. Bu qayda da sadəcə 1 dəyişən sayəsində Add, Edit, Delete methodlarını işlətməlisiz.
             Bunu etmək üçün biraz araşdırmalı olacaqsız.
             */
            RunAnyMethod delegateMethod = new RunAnyMethod(Add);
            delegateMethod();

            delegateMethod = new RunAnyMethod(Edit);
            delegateMethod();

            delegateMethod = new RunAnyMethod(Delete);
            delegateMethod();
            #endregion



            #region Solution of past Homework 2
            List<Car> cars = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                    City = "Baku",
                    Brand = "Lexus",
                    Model = "GX460",
                    Year = 2021,
                    Color = ColorEnum.Black,
                    Engine = 4500,
                    HP = 296,
                    Km = 156.126m,
                    GearboxType = GearBoxTypeEnum.Automatic,
                    Price = 200.000m
                },
                new Car()
                {
                    Id = 1,
                    City = "Baku",
                    Brand = "Mercedes",
                    Model = "G65 AMG",
                    Year = 2022,
                    Color = ColorEnum.Black,
                    Engine = 6500,
                    HP = 412,
                    Km = 0,
                    GearboxType = GearBoxTypeEnum.Automatic,
                    Price = 380.000m
                }
            };


            var q1 = cars.Where(m => m.Brand == "Mercedes" && m.Engine <= 4200 && m.City == "Baku");

            var q2 = cars.Where(m => m.City != "Baku" && (m.Year >= 2015 && m.Year <= 2020));

            var q3 = cars.FindAll(m => m.Km == 0 && m.Model.ToLower().Contains("ml"));

            var q4 = cars.FirstOrDefault(m => m.GearboxType == GearBoxTypeEnum.Automatic && (m.Price > 15000 && m.Price < 17500));

            var q5 = cars.FirstOrDefault(m =>
                    (m.Color != ColorEnum.Red || m.Color != ColorEnum.Black) &&
                    (m.Engine > 2000 && m.Engine < 4000) &&
                    (m.GearboxType != GearBoxTypeEnum.Robot) &&
                    (m.Year >= 2010));

            var q6 = cars.FindAll(m =>
                    (m.Brand == "Lexus" && m.Price <= 30000) ||
                    (m.Brand == "Mercedes" && m.Price <= 45000));
            #endregion

            #region Solution of past Homework 3
            int[] arr = new int[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i;
            }

            var arr_query1 = arr.Where(m => m % 2 == 0);

            var arr_query2 = arr.Where(m => m > 400 && m <= 550 && m % 2 != 0);
            #endregion
        }

        public delegate void RunAnyMethod();

        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Add method");
        }

        public static void Delete()
        {
            Console.WriteLine("Add method");
        }
    }
}

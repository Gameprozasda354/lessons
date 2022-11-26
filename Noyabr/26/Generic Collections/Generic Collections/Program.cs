using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before Generic Collections
            VirtualDatabase virtualDb = new VirtualDatabase();
            virtualDb.Add(10);
            virtualDb.Add(20);
            #endregion

            #region Using simple Generic Collections
            //Not Generic Collection
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Bir");
            //<T> : T tipi, .NET framework'unun icinde olan ve ya bizim yaratdigimiz her hansisa bir tip demekdir.
            List<int> genericList = new List<int>();

            genericList.Add(5);
            genericList.Add(15);
            genericList.Add(20);
            //error: genericList.Add("on");

            List<string> names = new List<string>();
            names.Add("Orkhan");
            names.Add("Musa");
            names.Add("Samir");
            //error: names.Add(5);

            List<bool> booleanGC = new List<bool>();
            booleanGC.Add(true);
            booleanGC.Add(false);
            #endregion

            #region Custom types with Generic Collections & Linq methods
            List<Student> students = new List<Student>();

            //1-ci yol
            students.Add(new Student()
            {
                Id = 1,
                Name = "Cavid",
                Surname = "Cavidov",
                Age = 25
            });

            //2-ci yol
            Student student = new Student()
            {
                Id = 2,
                Name = "Hasan",
                Surname = "Hasanov",
                Age = 23
            };

            students.Add(student);

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("ID: {0} \r\nName: {1}\r\nSurname: {2}\r\nAge: {3}",
                                    students[i].Id,
                                    students[i].Name,
                                    students[i].Surname,
                                    students[i].Age);
            }

            foreach (var item in students)
            {
                Console.WriteLine("ID: {0} \r\nName: {1}\r\nSurname: {2}\r\nAge: {3}",
                                    item.Id,
                                    item.Name,
                                    item.Surname,
                                    item.Age);
            }
            #endregion


            #region Task in Lesson
            /*
             numbersToAdd adli bir arrayin ve bir dene de numbers adinda List'in olsun. Ikisi de int tipinde olmalidir. Sonra numbersToAdd
             array'inin icindeki reqemleri, numbers list'ine elave etmeye calis.
             */

            List<int> numbers = new List<int>();
            numbers.Add(1);

            int[] numbersToAdd = new int[10];

            numbersToAdd[0] = 10;
            numbersToAdd[1] = 20;
            numbersToAdd[2] = 30;
            numbersToAdd[3] = 40;
            numbersToAdd[4] = 50;
            numbersToAdd[5] = 60;
            numbersToAdd[6] = 70;
            numbersToAdd[7] = 80;
            numbersToAdd[8] = 90;
            numbersToAdd[9] = 100;

            //Helleri
            //1.Yol
            for (int i = 0; i < numbersToAdd.Length; i++)
            {
                numbers.Add(numbersToAdd[i]);
            }

            //2.Yol
            numbers.AddRange(numbersToAdd);


            List<double> doubleList = new List<double>();
            doubleList.Add(10.1);
            doubleList.Add(20.1);
            doubleList.Add(30.1);
            doubleList.Add(40.1);

            var capacityOfDoubleList = doubleList.Capacity;

            var countOfDoubleList = doubleList.Count;

            doubleList.Add(50.1);

            var secondCapacityOfDoubleList = doubleList.Capacity;
            var secondCountOfDoubleList = doubleList.Count;

            doubleList.TrimExcess();

            var a = doubleList.Capacity;
            var b = doubleList.Count;

            doubleList.ForEach(i => Console.WriteLine(i));
            //=> isaresi bir Lambda Expression ifadesidir
            #endregion
        }
    }
}

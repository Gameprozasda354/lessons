﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Student student = new Student();

            int rate = 45;

            Console.WriteLine("Adınızı daxil edin:");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı daxil edin:");
            string surName = Console.ReadLine();

            Console.WriteLine("1. balınızı daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. balınızı daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. balınızı daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());

            int answer = student.CalcAverage(a, b, c);

            Console.WriteLine($"{surName} {name} siz imtahandan {student.RateAverage(answer, rate)}");

            Console.ReadLine();
        }
    }
}

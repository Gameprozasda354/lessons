using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Student
    {

        public int CalcAverage(int a, int b, int c)
        {
            int answer = (a + b + c) / 3;

            return answer;
        }

        public void CalcAverage()
        {

        }

        public string RateAverage(string name, string surname, int a,int b, int c, int rate)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int result = CalcAverage(a, b, c);
            string answer = surname + name + " siz imtahandan kəsildiniz";

            if (result > rate)
            {
                answer = surname + " " + name + " siz imtahandan keçdiniz";
            }

            return answer;
        }

    }
}

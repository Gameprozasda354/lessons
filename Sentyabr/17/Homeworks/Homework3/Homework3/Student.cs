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

        public string RateAverage(int result, int rate)
        {
            string answer = "kəsildiniz";

            if(result > rate)
            {
                answer = "keçdiniz";
            }

            return answer;
        }

    }
}

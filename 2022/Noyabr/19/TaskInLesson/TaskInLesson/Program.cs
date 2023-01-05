using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            foreach(int i in numbersToAdd)
            {
                numbers.Add(i);
            }

        }
    }
}

using MathOperations;
using MathOperations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathoperation = new MathOperation();

            decimal a = 70;
            decimal b = 40;

            decimal result = mathoperation.Calculate(a, b, MathOperationTypeEnum.Addition);

        }
    }
}

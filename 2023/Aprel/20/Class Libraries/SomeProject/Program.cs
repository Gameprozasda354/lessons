using MathOperations;
using MathOperations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation m = new MathOperation();
            decimal res = m.Calculate(15, 45, MathOperationTypeEnum.Addition);
        }
    }
}

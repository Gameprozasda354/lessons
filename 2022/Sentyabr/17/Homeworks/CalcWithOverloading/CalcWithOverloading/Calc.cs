using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithOverloading
{
    internal class Calc
    {

        public void ShowMenu()
        {
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Çıxma");
            Console.WriteLine("3.Vurma");
            Console.WriteLine("4.Bölmə");
            Console.WriteLine("Əməliyyatı seçin:");
        }
        
        public decimal Add(decimal a, decimal b)
        {
            decimal c = a + b;

            return c;
        }

        public decimal Add(decimal a, decimal b, decimal c)
        {
            decimal result = a + b + c;
            return result;
        }

        public decimal Subtracting(decimal a, decimal b)
        {
            decimal c = a - b;

            return c;
        }

        public decimal Subtracting(decimal a, decimal b, decimal c)
        {

            decimal e = a - b - c;

            return e;
        }

        public decimal Multiple(decimal a, decimal b)
        {
            decimal c = a * b;

            return c;
        }

        public decimal Multiple(decimal a, decimal b, decimal c)
        {

            decimal d = a * b * c;

            return d;
        }

        public decimal Divide(decimal a, decimal b)
        {
            decimal c = a / b;

            return c;
        }

        public decimal Divide(decimal a, decimal b, decimal c)
        {
            decimal d = a / b / c;

            return d;
        }

        public void ShowResult(decimal a, decimal b, decimal result, string calcType)
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, calcType, b, result);
        }

        public void ShowResult(decimal a, decimal b, decimal c, decimal result, string calcType)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} = {5}", a, calcType, b, calcType, c,  result);
        }

    }
}

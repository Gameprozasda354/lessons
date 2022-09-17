using System;

namespace MathOperations
{
    public class Calculate
    {
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Cixma");
            Console.WriteLine("3 - Bolme");
            Console.WriteLine("4 - Vurma");
            Console.WriteLine("Emeliyyati secin: ");
        }

        //toplama
        public decimal Addition(decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            return result;
        }

        //cixma
        public decimal Subtraction(decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            return result;
        }

        //bolme
        public decimal Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
                return 0;

            decimal result = num1 / num2;
            return result;
        }

        //vurma
        public decimal Multiplication(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            return result;
        }

        //netice
        public void ShowResult(decimal num1, decimal num2, decimal result, string operatorStr)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, operatorStr, num2, result); //5 + 10 = 15
        }
    }
}

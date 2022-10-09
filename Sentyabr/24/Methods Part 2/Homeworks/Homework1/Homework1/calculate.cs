using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class calculate
    {
        public int Calculate()
        {


            decimal Add(decimal a, decimal b)
            {
                decimal c = Convert.ToDecimal(a + b);
                return c;
            }

            decimal Add1(int a, int b)
            {
                decimal c = a + b;
                return c;
            }

            decimal Add2(string a, string b)
            {
                decimal c = Convert.ToDecimal(a) + Convert.ToDecimal(b);
                return c;
            }

            decimal Add3(string a, decimal b)
            {
                decimal c = Convert.ToDecimal(a) + b;
                return c;
            }

            decimal Add4(decimal a, int b)
            {
                decimal c = a + b;
                return c;
            }

            decimal Add5(string a, int b)
            {
                decimal c = Convert.ToDecimal(a) + b;
                return c;
            }

            decimal Substract(decimal a, decimal b)
            {
                decimal c = a - b;

                return c;
            }

            decimal Substract1(int a, int b)
            {
                decimal c = a - b;

                return c;
            }

            decimal Substract2(string a, string b)
            {
                decimal c = Convert.ToDecimal(a) - Convert.ToDecimal(b);
                return c;
            }

            decimal Substract3(string a, decimal b)
            {
                decimal c = Convert.ToDecimal(a) - b;
                return c;
            }

            decimal Substract4(decimal a, int b)
            {
                decimal c = a - b;
                return c;
            }

            decimal Substract5(string a, int b)
            {
                decimal c = Convert.ToDecimal(a) - b;
                return c;
            }

            decimal Multiple(decimal a, decimal b)
            {
                decimal c = a * b;

                return c;
            }

            decimal Multiple1(int a, int b)
            {
                decimal c = a * b;

                return c;
            }

            decimal Multiple2(string a, string b)
            {
                decimal c = Convert.ToDecimal(a) * Convert.ToDecimal(b);
                return c;
            }

            decimal Multiple3(string a, decimal b)
            {   
                decimal c = Convert.ToDecimal(a) * b;
                return c;
            }

            decimal Multiple4(decimal a, int b)
            {
                decimal c = a * b;
                return c;
            }

            decimal Multiple5(string a, int b)
            {
                decimal c = Convert.ToDecimal(a) * b;
                return c;
            }

            decimal Divide(decimal a, decimal b)
            {
                if (b == 0)
                    return 0;

                else
                {
                    decimal c = a / b;
                    return c;
                }
            }

            decimal Divide1(int a, int b)
            {
                if (b == 0)
                    return 0;

                else
                {
                    decimal c = a / b;
                    return c;
                }
            }

            decimal Divide2(string a, string b)
            {
                int a1 = Convert.ToInt32(a);
                int b1 = Convert.ToInt32(b);

                if (b1 == 0)
                    return 0;

                else
                {
                    decimal c = a1 / b1;
                    return c;
                }
            }

            decimal Divide3(string a, decimal b)
            {
                decimal a1 = Convert.ToInt32(a);

                if (b == 0)
                    return 0;

                else
                {
                    decimal c = a1 / b;
                    return c;
                }
            }

            decimal Divide4(decimal a, int b)
            {
                decimal a1 = Convert.ToInt32(a);

                if (b == 0)
                    return 0;

                else
                {
                    decimal c = a1 / b;
                    return c;
                }
            }

            decimal Divide5(string a, int b)
            {
                decimal a1 = Convert.ToInt32(a);

                if (b == 0)
                    return 0;

                else
                {
                    decimal c = a1 / b;
                    return c;
                }
            }





            return 1;
        }
    }
}

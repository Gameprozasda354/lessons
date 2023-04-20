using MathOperations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class MathOperation
    {
        #region Public methods
        public decimal Calculate(decimal a, decimal b, MathOperationTypeEnum operationType)
        {
            switch (operationType)
            {
                case MathOperationTypeEnum.Addition:
                    return Addition(a, b);
                case MathOperationTypeEnum.Subtraction:
                    return Subtraction(a, b);
                case MathOperationTypeEnum.Multiplication:
                    return Multiplication(a, b);
                case MathOperationTypeEnum.Divide:
                    return Divide(a, b);
                default:
                    throw new Exception("Səhv əməliyyat növü seçilib!");
            }
        }
        #endregion

        #region Private methods
        private decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        private decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        private decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        private decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
                throw new Exception("Ədədi sıfıra bölə bilməzsiniz!");

            return a / b;
        }
        #endregion
    }
}

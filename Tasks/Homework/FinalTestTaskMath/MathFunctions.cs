using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestTaskMath
{
    internal class Class1
    {
        public class MathFunctions
        {
            public double Factorial(int number)
            {
                if (number < 0)
                {
                    throw new ArgumentException("Факториал не может быть вычислен для отрицательных чисел");
                }

                double result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }

            public double Power(double number, int exponent)
            {
                if (exponent < 0)
                {
                    throw new ArgumentException("Степень не может быть отрицательной");
                }

                return Math.Pow(number, exponent);
            }

            public double Square(double number)
            {
                return number * number;
            }
        }
    }
}

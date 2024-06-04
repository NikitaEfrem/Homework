using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest4
{
    public class MathFunctions
    {
        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным.");
            }

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public double Power(double number, int power)
        {
            if (power < 0)
            {
                throw new ArgumentException("Степень должна быть неотрицательной.");
            }

            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        public int Square(int number)
        {
            return number * number;
        }
    }
}

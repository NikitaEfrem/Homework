using static FinalTestTaskMath.Class1;

namespace FinalTestTaskMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathFunctions math = new MathFunctions();

            try
            {
                double result = math.Factorial(5);
                Console.WriteLine("Факториал 5 равен " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            try
            {
                double result = math.Power(2, 3);
                Console.WriteLine("2 в степени 3 равен " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            try
            {
                double result = math.Square(4);
                Console.WriteLine("Квадрат 4 равен " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}

namespace FinalTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctions mathFunctions = new MathFunctions();

            try
            {
                Console.Write("Введите число для вычисления факториала: ");
                int number = int.Parse(Console.ReadLine());
                int result = mathFunctions.Factorial(number);
                Console.WriteLine($"Факториал числа {number} равен {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            try
            {
                Console.Write("Введите число для возведения в степень: ");
                double number = double.Parse(Console.ReadLine());
                Console.Write("Введите степень: ");
                int power = int.Parse(Console.ReadLine());
                double result = mathFunctions.Power(number, power);
                Console.WriteLine($"Число {number} в степени {power} равно {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            try
            {
                Console.Write("Введите число для вычисления квадрата: ");
                int number = int.Parse(Console.ReadLine());
                int result = mathFunctions.Square(number);
                Console.WriteLine($"Квадрат числа {number} равен {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

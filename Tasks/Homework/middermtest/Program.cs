namespace midtermtest
{
    internal class Program
    {
        static void Main()
        {
            int[,] mas = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Console.Write("{");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]}");
                    if (j < mas.GetLength(1) - 1)
                    {
                        Console.Write(" , ");
                    }
                }
                Console.Write("}");
                if (i < mas.GetLength(0) - 1)
                {
                    Console.Write(" , ");
                }
            }
            Console.WriteLine("}");
            return;
        }
    }
}

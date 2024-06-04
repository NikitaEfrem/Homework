namespace FinalTest1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char[,] array =
            {
                {'y', ' ', 'N', 'i', ' ', 'D', 'Q'},
                {'m', 'h', ' ', 'g', 'x', ' ', 'Q'},
                {'D', 'u', ' ', 'G', 'p', ' ', 'x'},
                {'v', 'o', ' ', 'Q', '1', ' ', 'd'},
                {'Q', 'u', ' ', 'y', 'j', ' ', 'X'}
            };

            ArrayDiagonalChange diagonalChange = new ArrayDiagonalChange();
            char[,] result = diagonalChange.ChangeDiagonal(array);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

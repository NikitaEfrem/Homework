using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    public class ArrayDiagonalChange
    {
        public char[,] ChangeDiagonal(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            char[,] result = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i + j < rows - 1)
                    {
                        result[i, j] = 'X';
                    }
                    else
                    {
                        result[i, j] = array[i, j];
                    }
                }
            }

            return result;
        }
    }
}

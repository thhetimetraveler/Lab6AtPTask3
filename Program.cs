using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6AtPTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int rows = 6;
            const int cols = 3;

            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);

            Console.WriteLine("Generated Matrix:");
            PrintMatrix(matrix);

            (int minValue, int minRow, int minCol) = FindMinElementByAbsoluteValue(matrix);
            Console.WriteLine($"\nMinimum absolute value element: {minValue}");
            Console.WriteLine($"Position: Row {minRow + 1}, Column {minCol + 1}");
        }

        static void FillMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-100, 101);
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        static (int minValue, int row, int col) FindMinElementByAbsoluteValue(int[,] matrix)
        {
            int minValue = Math.Abs(matrix[0, 0]);
            int minRow = 0, minCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (Math.Abs(matrix[i, j]) < minValue)
                    {
                        minValue = Math.Abs(matrix[i, j]);
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            return (matrix[minRow, minCol], minRow, minCol);
        }
    }
}

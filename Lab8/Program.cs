using System;
using System.Linq;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = GenerateSquareMatrix(4);

            PrintMatrix(matrix);

            OrderByMainDiagonal(ref matrix);

            PrintMatrix(matrix);

            Console.ReadKey();
        }

        static void PrintMatrix(double[,] matrix)
        {
            if (matrix == null)
            {
                Console.WriteLine("Oopsie! Matrix is null!");
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j],8}");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        static double[,] GenerateSquareMatrix(int n)
        {
            Random random = new Random();
            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Math.Round(random.NextDouble() * 100 - 50, 2);
                }
            }

            return matrix;
        }

        static int[] GetOrderedIndexes(double[,] matrix)
        {
            int depth = matrix.GetLength(0);
            int[] orderedIndexes = new int[depth];

            ProcessRow(0);

            return orderedIndexes[depth - 1] == -1 ? null : orderedIndexes;

            void ProcessRow(int rowIndex)
            {
                for (int i = rowIndex; i < depth; i++)
                {
                    orderedIndexes[i] = -1;
                }

                for (int j = 0; j < depth; j++)
                {
                    if (orderedIndexes[depth - 1] == -1 && !Contains(orderedIndexes, j) &&
                        (rowIndex == 0 || matrix[rowIndex, j] >= matrix[rowIndex - 1, orderedIndexes[rowIndex - 1]]))
                    {
                        orderedIndexes[rowIndex] = j;

                        if (rowIndex < depth - 1)
                        {
                            ProcessRow(rowIndex + 1);
                        }
                    }
                }
            }
        }

        static void OrderByMainDiagonal(ref double[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);

            int[] orderedIndexes = GetOrderedIndexes(matrix);

            if (orderedIndexes == null)
            {
                matrix = null;
            }
            else
            {
                double[,] orderedMatrix = new double[rowsCount, columnsCount];

                for (int j = 0; j < columnsCount; j++)
                {
                    for (int i = 0; i < rowsCount; i++)
                    {
                        orderedMatrix[i, j] = matrix[i, orderedIndexes[j]];
                    }
                }

                matrix = orderedMatrix;
            }
        }

        static bool Contains(int[] array, int element)
        {
            bool contains = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    contains = true;
                }
            }

            return contains;
        }
    }
}

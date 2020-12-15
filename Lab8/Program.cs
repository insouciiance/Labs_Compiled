using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GenerateSquareMatrix(4);
            
            PrintMatrix(matrix);

            OrderByMainDiagonal(ref matrix);

            PrintMatrix(matrix);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
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
                        Console.Write($"{matrix[i, j],4}");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        static int[,] GenerateSquareMatrix(int n)
        {
            Random random = new Random();
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-50, 51);
                }
            }

            return matrix;
        }

        static int[] GetOrderedIndexes(int[,] matrix)
        {
            int depth = matrix.GetLength(0);
            int[] orderedIndexes = new int[depth];

            for (int i = 0; i < depth; i++)
            {
                orderedIndexes[i] = -1;
            }

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

        static void OrderByMainDiagonal(ref int[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);

            int[,] orderedMatrix = new int[rowsCount, columnsCount];
            int[] orderedIndexes = GetOrderedIndexes(matrix);

            if (orderedIndexes == null)
            {
                matrix = null;
                return;
            }

            for (int j = 0; j < columnsCount; j++)
            {
                for (int i = 0; i < rowsCount; i++)
                {
                    orderedMatrix[i, j] = matrix[i, orderedIndexes[j]];
                }
            }

            matrix = orderedMatrix;
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

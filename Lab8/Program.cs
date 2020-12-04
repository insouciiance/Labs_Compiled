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

            matrix = OrderByMainDiagonal(matrix);

            PrintMatrix(matrix);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                Console.WriteLine("Oopsie! Matrix is null!~");
                return;

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],-4}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static int[,] GenerateSquareMatrix(int n)
        {
            Random random = new Random();
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                }
            }

            return matrix;
        }

        static int[] GetOrderedIndexes(int[,] matrix)
        {
            int depth = matrix.GetLength(0);
            int[] orderedIndexes = new int[depth].Select((x, i) => -1).ToArray();

            ProcessRow(0);

            return orderedIndexes.Contains(-1) ? null : orderedIndexes;

            void ProcessRow(int rowIndex)
            {
                for (int i = rowIndex; i < depth; i++)
                {
                    orderedIndexes[i] = -1;
                }

                for (int i = 0; i < depth; i++)
                {
                    if (orderedIndexes[depth - 1] == -1 && (rowIndex == 0 || matrix[rowIndex, i] >= matrix[rowIndex - 1, orderedIndexes[rowIndex - 1]] && !orderedIndexes.Contains(i)))
                    {
                        orderedIndexes[rowIndex] = i;

                        if (rowIndex < depth - 1)
                        {
                            ProcessRow(rowIndex + 1);
                        }
                    }
                }
            }
        }

        static int[,] OrderByMainDiagonal(int[,] matrix)
        {
            int[,] orderedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int[] orderedIndexes = GetOrderedIndexes(matrix);

            if (orderedIndexes == null)
            {
                return null;
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    orderedMatrix[i, j] = matrix[i, orderedIndexes[j]];
                }
            }

            return orderedMatrix;
        }
    }
}

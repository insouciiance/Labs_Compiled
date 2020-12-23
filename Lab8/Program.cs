using System;
using static Matrix.MatrixHelper;

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
    }
}

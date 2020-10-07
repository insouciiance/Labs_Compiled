using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double angleInRadians = 3;

            double angleInDegrees = ConvertToDegrees(angleInRadians);

            Console.WriteLine(angleInDegrees);

            Console.ReadKey();
        }

        private static double ConvertToDegrees(double angleInRadians)
        {
            double angleInDegrees = angleInRadians * 180 / Math.PI;

            return angleInDegrees;
        }
    }
}

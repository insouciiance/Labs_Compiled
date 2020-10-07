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
            Console.Write("Enter an angle in radians: ");
            string angleString = Console.ReadLine();
            double angleInRadians = Convert.ToDouble(angleString, CultureInfo.InvariantCulture);

            double angleInDegrees = ConvertToDegrees(angleInRadians);

            Console.WriteLine($"Your angle in degrees: {angleInDegrees}");

            Console.ReadKey();
        }

        private static double ConvertToDegrees(double angleInRadians)
        {
            double angleInDegrees = angleInRadians * 180 / Math.PI;

            return angleInDegrees;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                return;
            }

            double x;
            double prevX;

            if (a <= 1)
            {
                x = Math.Min(2 * a, 0.95);
            }
            else if (a > 1 && a < 25)
            {
                x = a / 5;
            }
            else
            {
                x = a / 25;
            }

            do
            {
                Console.WriteLine(x);
                prevX = x;
                x = prevX * 4 / 5 + a / (5 * Math.Pow(prevX, 4));
            } while (Math.Abs(x - prevX) > 0.0001);

            Console.WriteLine(x);

            Console.WriteLine($"The fifth root of {a} is {x}");

            Console.ReadKey();
        }
    }
}

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

            double x = a;
            double prevX;

            do
            {
                Console.WriteLine(x);
                prevX = x;
                x = prevX * 4 / 5 + a / (5 * Math.Pow(prevX, 4));
            } while (Math.Abs(x - prevX) > 0.0001);

            Console.WriteLine($"{x}");

            Console.ReadKey();
        }
    }
}

using System;

// Вариант 26 - найти корень пятой степени из числа по реккурентной формуле

namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (!double.TryParse(Console.ReadLine(), out double a) || a == 0) // ввод числа а из консоли и его валидация
            {
                return; 
            }

            double x;
            double prevX;

            if (a <= 1) // присваивание локальной переменной х значения в зависимости от а
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
            } while (Math.Abs(x - prevX) > 0.0001); // пока не получено требуемое приближение - выполнять цикл

            Console.WriteLine(x);

            Console.WriteLine($"The fifth root of {a} is {x}");

            Console.ReadKey();
        }
    }
}

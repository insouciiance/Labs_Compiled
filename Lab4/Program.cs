// Вариант 26
// Найти сумму последовательности

using System;

namespace Lab4
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) // валидация значения n, введенного из консоли
            {
                return;
            }

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int ai;
                int bi;

                if (i % 2 == 1) // присвоение локальным переменным ai и bi значений в зависимости от значения i
                {
                    ai = i;
                    bi = (int)Math.Pow(i, 2);
                }
                else
                {
                    ai = i / 2;
                    bi = i + 7;
                }

                int xi = (int)Math.Pow(ai - bi, 2); // определение i-го значения последовательности

                sum += xi; // вычисление суммы

                Console.WriteLine($"Sum == {sum}");
            }

            Console.WriteLine($"The result is: {sum}");

            Console.ReadKey(); // задержка
        }
    }
}

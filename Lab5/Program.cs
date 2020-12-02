using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter n: ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) // ввод числа n с клавиатуры и его валидация
            {
                return;
            }

            for (int c = 1; c <= n; c++)
            {
                for (int b = 1; b <= c; b++)
                {
                    for (int a = 1; a <= b; a++)
                    {
                        if (c * c == a * a + b * b) // проверка на то, является ли текущая тройка чисел a, b, c пифагоровой
                        {
                            Console.WriteLine($"a={a} b={b} c={c}");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

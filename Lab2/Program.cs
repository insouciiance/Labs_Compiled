//34. Робота світлофора для водіїв запрограмована таким чином: на початку кожної години
//протягом трьох хвилин горить зелений сигнал, потім протягом однієї хвилини - жовтий,
//протягом двох хвилин - червоний, протягом трьох хвилин - знову зелений. Дано дійсне
//число t, що означає час в хвилинах, що минув з початку чергової години. Визначити,
//сигнал якого кольору горить для водіїв в цей момент.

using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your positive time in minutes: ");

            int.TryParse(Console.ReadLine(), out int t); // получаем t из консоли и приводим к int

            int remainder = t % 9;                         // определение переменной remainder типа int и присваивание ей остатка от деления на 9

            int color;                                     // объявление переменной color типа int
            
            if (remainder >= 0 && remainder < 3)           // определение цвета в зависимости от значения переменной remainder
            {
                color = 0;
            }
            else
            {
                if (remainder >= 3 && remainder < 4)
                {
                    color = 1;
                }
                else
                {
                    if (remainder >= 4 && remainder < 6)
                    {
                        color = 2;
                    }
                    else
                    {
                        color = 0;
                    }
                }
            }

            Console.WriteLine("The color is {0} ({1})", color, color switch  
            {
                0 => "Green",
                1 => "Yellow",
                2 => "Red",
            });                                          

            Console.ReadKey();
        }
    }
}

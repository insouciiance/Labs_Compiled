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
            
            double angleInRadians = double.Parse(Console.ReadLine());       //ввод угла в радианах из консоли и приведение его к типу double

            double angleInDegrees = angleInRadians * 180 / Math.PI;         //получение величины угла в градусах по формуле
            
            Console.WriteLine($"Your angle in degrees: {angleInDegrees}");  //вывод угла в градусах
            Console.ReadKey();
        }
    }
}

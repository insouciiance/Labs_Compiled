using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int[] array;
            int length;

            (array, length) = InputArray();

            if (array == null)
            {
                return;
            }

            int numberOfMatches = FindAndReplace(array, length);

            Console.WriteLine($"\nNumber of matches: {numberOfMatches}");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"[{i}]:{array[i]}");
            }

            Console.ReadKey();
        }

        private static (int[], int) InputArray()
        {
            Console.Write("Enter the size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length < 0)
            {
                return (null, -1);
            }

            int[] array = new int[length];

            Console.WriteLine("Enter the array:");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"[{i}]:");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    return (null, -1);
                }
            }

            return (array, length);
        }

        private static int Max(int[] array, int length)
        {
            int max = 0;
            
            for (int i = 0; i < length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }    
            }

            return max;
        }

        private static int FindAndReplace(int[] array, int length)
        {
            int maxElement = Max(array, length);
            int numberOfMatches = 0;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0 && array[i] % 2 == 1)
                {
                    array[i] = maxElement - array[i];
                    numberOfMatches++;
                }
            }

            return numberOfMatches;
        }
    }
}

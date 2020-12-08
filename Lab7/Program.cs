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
            int[] array = InputArray();

            if (array == null)
            {
                return;
            }

            int numberOfMatches = FindAndReplace(array);

            Console.WriteLine($"\nNumber of matches: {numberOfMatches}");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}]: {array[i]}");
            }

            Console.ReadKey();
        }

        private static int[] InputArray()
        {
            Console.Write("Enter the size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length < 0)
            {
                return null;
            }

            int[] array = new int[length];

            Console.WriteLine("Enter the array:");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"[{i}]: ");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    return null;
                }
            }

            return array;
        }

        private static int Max(int[] array)
        {
            int max = int.MinValue;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }    
            }

            return max;
        }

        private static int FindAndReplace(int[] array)
        {
            int maxElement = Max(array);
            int numberOfMatches = 0;

            for (int i = 0; i < array.Length; i++)
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

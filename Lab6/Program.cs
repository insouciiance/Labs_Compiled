using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray() ?? new int[0];

            bool result = ContainsPalindromes(array);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static bool ContainsPalindromes(int[] arr)
        {
            bool contains = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPalindrome(arr[i]))
                {
                    contains = true;
                }
            }

            return contains;

            bool IsPalindrome(int n)
            {
                bool isPalindrome = true;

                int digitsCount = (int)Math.Log10(n) + 1;

                for (int i = 0; i < digitsCount / 2; i++)
                {
                    int firstDigitToCompare = n / (int)Math.Pow(10, digitsCount - i - 1) % 10;
                    int secondDigitToCompare = n / (int)Math.Pow(10, i) % 10;

                    if (firstDigitToCompare != secondDigitToCompare)
                    {
                        isPalindrome = false;
                    }
                }

                return isPalindrome;
            }
        }
    }
}

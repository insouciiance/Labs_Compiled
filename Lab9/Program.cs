using System;
using static Text.StringHelper;

namespace Lab9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int wordsCount = SplitWordsCount(input);
            Console.WriteLine($"Number of words between ';': {wordsCount}");

            Console.ReadKey();
        }
    }
}

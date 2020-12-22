using System.Collections.Generic;
using System.Linq;

namespace Text
{
    public static class StringHelper
    {
        public static int SplitWordsCount(string input)
        {
            string[] splitInput = input.Split(';');
            IEnumerable<string> separateStrings = splitInput.Skip(1).SkipLast(1);
            int wordsCount = separateStrings.Count(s => s.Trim() != ""); 

            return wordsCount;
        }
    }
}
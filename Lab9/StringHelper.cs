using System.Linq;

namespace Text
{
    public static class StringHelper
    {
        public static int SplitWordsCount(string input)
        {
            string[] splitInput = input.Split(';');
            var separateStrings = splitInput.Skip(1).SkipLast(1);
            int wordsCount = separateStrings.Count(s => s.Trim() != ""); 

            return wordsCount;
        }
    }
}
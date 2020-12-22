using System.Linq;

namespace Text
{
    public static class StringHelper
    {
        public static int SplitWordsCount(string input) => input.Split(';').Skip(1).SkipLast(1).Count(s => !string.IsNullOrWhiteSpace(s));
    }
}

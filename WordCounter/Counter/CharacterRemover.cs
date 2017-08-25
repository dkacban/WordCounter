using System.Linq;

namespace WordCounter.Counter
{
    public class CharacterRemover
    {
        public static string[] RemoveNumbers(string[] words)
        {
            int parseResult;
            var wordsExcludingNumbers = words.Where(word => !int.TryParse(word, out parseResult));

            return wordsExcludingNumbers.ToArray();
        }

        public static string RemoveDots(string input)
        {
            return input.Replace(".", string.Empty);
        }
    }
}

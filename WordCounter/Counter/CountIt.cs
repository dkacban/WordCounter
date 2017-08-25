using System.Linq;
using WordCounter.Sorter;

namespace WordCounter.Counter
{
    public class CountIt
    {
        public string CountWords(string document)
        {
            var input = CharacterRemover.RemoveDots(document);
            var allWords = input.Split(null).Where(w => !string.IsNullOrEmpty(w));
            var onlyRealWords = CharacterRemover.RemoveNumbers(allWords.ToArray());
            var sortedWords = WordsSorter.Sort(onlyRealWords);
            var builder = new OutputBuilder(sortedWords);

            return builder.Build();
        }
    }
}

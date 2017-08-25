using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Counter
{
    internal class OutputBuilder
    {
        private const string Header = "Number of words: ";
        private string[] _words;

        public OutputBuilder(string[] words)
        {
            _words = words.Select(w => w.ToLower()).ToArray();
        }
        private string GenerateHeader(int wordsNumber)
        {
            return $"{Header}{wordsNumber}";
        }

        private string GenerateScrambledBody(string[] words)
        {
            var scrambledWords = words.GroupBy(w => w).Select(w => ReverseString(w.Key)).ToArray();

            var capitalizedScrambledWords = new List<string>();

            foreach (var scrambledWord in scrambledWords)
            {
                var result = "";
                for (var i = 0; i < scrambledWord.Length; i++)
                {
                    var letter = scrambledWord[i];
                    if (i % 2 != 0)
                    {
                        result += letter.ToString().ToUpper().ToCharArray().First();
                    }
                    else
                    {
                        result += letter;
                    }
                }
                capitalizedScrambledWords.Add(result);
            }


            var scrumbledBody = string.Join(Environment.NewLine, capitalizedScrambledWords);

            return scrumbledBody;
        }

        private string ReverseString(string word)
        {
            return new string(word.ToCharArray().Reverse().ToArray());
        }

        private string GenerateBody(string[] words)
        {
            var wordsWithNumbers = words.GroupBy(w => w).Select(w => $"{w.Key} {w.Count()}");

            var body = string.Join(Environment.NewLine, wordsWithNumbers.ToArray());

            return body;
        }

        internal string Build()
        {
            var header = GenerateHeader(_words.Length);
            var newLine = Environment.NewLine;
            var body = GenerateBody(_words);
            var scrambledBody = GenerateScrambledBody(_words);

            return $"{header}{newLine}{body}{newLine}{newLine}{scrambledBody}";
        }
    }
}

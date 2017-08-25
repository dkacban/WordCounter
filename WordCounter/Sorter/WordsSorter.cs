using System.Collections.Generic;

namespace WordCounter.Sorter
{
    public static class WordsSorter
    {
        public static string[] Sort(string[] input)
        {
            var sortedList = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentElement = input[i];

                var destinationIndex = sortedList.Count;
                for (var j = 0; j< sortedList.Count; j++)
                {
                    if (string.CompareOrdinal(currentElement, sortedList[j]) < 0)
                    {
                        destinationIndex = j;
                    }
                }

                sortedList.Insert(destinationIndex, currentElement);
            }

            return sortedList.ToArray();
        }
    }
}

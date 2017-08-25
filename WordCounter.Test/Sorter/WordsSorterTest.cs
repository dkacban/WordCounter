using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Sorter;

namespace WordCounter.Test.Sorter
{
    [TestClass]
    public class WordSorterTest
    {
        [TestMethod]
        public void ShouldSortArray()
        {
            var input = new string[] {"def", "abc"};

            var sorted = WordsSorter.Sort(input);
            Assert.AreEqual("abc", sorted[0]);
            Assert.AreEqual("def", sorted[1]);
        }

        [TestMethod]
        public void ShouldNotRearrangeSortedArray()
        {
            var input = new string[] { "abc", "def", "ghi"};

            var sorted = WordsSorter.Sort(input);
            Assert.AreEqual("abc", sorted[0]);
            Assert.AreEqual("def", sorted[1]);
            Assert.AreEqual("ghi", sorted[2]);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Counter;

namespace WordCounter.Test
{
    [TestClass]
    public class CountItTest
    {
        [TestMethod]
        public void ShouldCountSingleWords()
        {
            var counter = new CountIt();
            string result = counter.CountWords("ab bc");

            var expectedResult = "Number of words: 2\r\nab 1\r\nbc 1\r\n\r\nbA\r\ncB";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldIgnoreLetterCaseWords()
        {
            var counter = new CountIt();
            string result = counter.CountWords("AB Cd");

            var expectedResult = "Number of words: 2\r\nab 1\r\ncd 1\r\n\r\nbA\r\ndC";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldCountOneAndTwoWords()
        {
            var counter = new CountIt();
            string result = counter.CountWords("a b b");

            var expectedResult = "Number of words: 3\r\na 1\r\nb 2\r\n\r\na\r\nb";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldSkipNumbersAndDots()
        {
            var counter = new CountIt();
            string result = counter.CountWords("a b b. 1 2.. 3");

            var expectedResult = "Number of words: 3\r\na 1\r\nb 2\r\n\r\na\r\nb";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldCapitalizeEvenLetters()
        {
            var counter = new CountIt();
            string result = counter.CountWords("abcd de");

            var expectedResult = "Number of words: 2\r\nabcd 1\r\nde 1\r\n\r\ndCbA\r\neD";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldSortWords()
        {
            var counter = new CountIt();
            string result = counter.CountWords("it do");

            var expectedResult = "Number of words: 2\r\ndo 1\r\nit 1\r\n\r\noD\r\ntI";
            Assert.AreEqual(expectedResult, result);
        }
    }
}

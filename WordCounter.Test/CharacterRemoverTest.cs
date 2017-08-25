using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Counter;

namespace WordCounter.Test
{
    [TestClass]
    public class CharacterRemoverTest
    {
        [TestMethod]
        public void ShouldRemoveSingleNumber()
        {
            string[] words = {"this", "are", "words", "123"};

            Assert.AreEqual(3, CharacterRemover.RemoveNumbers(words).Length);
        }

        [TestMethod]
        public void ShouldRemoveNumbersIfThereAreOnlyNumbers()
        {
            string[] words = { "567", "66", "345", "123" };

            Assert.AreEqual(0, CharacterRemover.RemoveNumbers(words).Length);
        }

        [TestMethod]
        public void ShouldRemoveDots()
        {
            var input = "abc.abc.";

            Assert.AreEqual(6, CharacterRemover.RemoveDots(input).Length);
        }
    }
}

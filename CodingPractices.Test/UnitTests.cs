using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPractices.Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FrequencyOfCharactersInAStringUnitTest()
        {
            var sentence = "Tekrar";

            var expectedOutput = "t: 1, e: 1, k: 1, r: 2, a: 1";

            var result = FrequencyOfCharactersInAString.JoinDictionaryElements(FrequencyOfCharactersInAString.FindFrequencyOfCharactersInAString(sentence));

            Assert.AreEqual(expectedOutput, result);
        }
    }
}

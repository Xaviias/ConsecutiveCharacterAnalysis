using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsecutiveCharacterAnalysis;

namespace ConsecutiveCharacterAnalysisTests
{
    [TestClass]
    public class ProgramTests
    {
        [DataTestMethod]
        [DataRow("abc", 3, DisplayName = "Normal case with unequal characters")]
        [DataRow("aaa", 1, DisplayName = "All characters identical")]
        [DataRow("ababc", 5, DisplayName = "Mixed case with repeating characters")]
        [DataRow("", 0, DisplayName = "Empty string")]
        [DataRow("a", 1, DisplayName = "Single character")]
        public void TestMaxUnequalConsecutiveCharacters(string input, int expected)
        {
            int result = Program.MaxUnequalConsecutiveCharacters(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("aaabbcc", 3, DisplayName = "Normal case with identical letters")]
        [DataRow("abc", 1, DisplayName = "All unique letters")]
        [DataRow("bbbba", 4, DisplayName = "Mixed case with letters")]
        [DataRow("a", 1, DisplayName = "Single letter")]
        [DataRow("aabbccdde", 2, DisplayName = "Pairs of letters")]
        [DataRow("", 0, DisplayName = "Empty string")]
        public void TestMaxConsecutiveIdenticalLetters(string input, int expected)
        {
            int result = Program.MaxConsecutiveIdenticalLetters(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("112233", 2, DisplayName = "Normal case with identical digits")]
        [DataRow("12345", 1, DisplayName = "All unique digits")]
        [DataRow("111a222", 3, DisplayName = "Mixed with letters")]
        [DataRow("1", 1, DisplayName = "Single digit")]
        [DataRow("999999999", 9, DisplayName = "All identical digits")]
        [DataRow("", 0, DisplayName = "Empty string")]
        public void TestMaxConsecutiveIdenticalDigits(string input, int expected)
        {
            int result = Program.MaxConsecutiveIdenticalDigits(input);

            Assert.AreEqual(expected, result);
        }
    }
}
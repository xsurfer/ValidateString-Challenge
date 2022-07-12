using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidateString;

namespace ValidateStringTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void IsOpeningBracket_ValidBrackets()
        {
            Assert.IsTrue(Solution.IsOpeningBracket('('));
            Assert.IsTrue(Solution.IsOpeningBracket('['));
            Assert.IsTrue(Solution.IsOpeningBracket('{'));
        }

        [TestMethod]
        public void IsOpeningBracket_NotABracket()
        {
            Assert.IsFalse(Solution.IsOpeningBracket('2'));
            Assert.IsFalse(Solution.IsOpeningBracket('b'));
            Assert.IsFalse(Solution.IsOpeningBracket('%'));
        }

        [TestMethod]
        public void MatchBracket_ValidBrackets()
        {
            Assert.IsTrue(Solution.MatchBracket('(',')'));
            Assert.IsTrue(Solution.MatchBracket('[', ']'));
            Assert.IsTrue(Solution.MatchBracket('{', '}'));
        }

        [TestMethod]
        public void MatchBracket_NotValidBrackets()
        {
            Assert.IsFalse(Solution.MatchBracket('(', ']'));
            Assert.IsFalse(Solution.MatchBracket('[', ')'));
            Assert.IsFalse(Solution.MatchBracket('{', ']'));
        }

        [TestMethod]
        public void ValidateString_ValidStrings()
        {
            Assert.IsTrue(Solution.ValidateString("()"));
            Assert.IsTrue(Solution.ValidateString("[]"));
            Assert.IsTrue(Solution.ValidateString("{}"));
            Assert.IsTrue(Solution.ValidateString("([{{}}])"));
        }

        [TestMethod]
        public void ValidateString_NotValidStrings()
        {
            Assert.IsFalse(Solution.ValidateString("([)"));
            Assert.IsFalse(Solution.ValidateString("[([)]"));
            Assert.IsFalse(Solution.ValidateString("]["));
        }

    }
}

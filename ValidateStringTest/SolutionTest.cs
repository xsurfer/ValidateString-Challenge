using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidateString;

namespace ValidateStringTest
{
    [TestClass]
    public class SolutionTest
    {
 
        [TestMethod]
        public void ValidateString_ValidStrings()
        {
            Assert.IsTrue(Solution.ValidateString(""));
            Assert.IsTrue(Solution.ValidateString("()"));
            Assert.IsTrue(Solution.ValidateString("[]"));
            Assert.IsTrue(Solution.ValidateString("{}"));
            Assert.IsTrue(Solution.ValidateString("([{{}}])"));
            Assert.IsTrue(Solution.ValidateString("{[()]}[](){}"));
        }

        [TestMethod]
        public void ValidateString_NotValidStrings()
        {
            Assert.IsFalse(Solution.ValidateString("([)"));
            Assert.IsFalse(Solution.ValidateString("[([)]"));
            Assert.IsFalse(Solution.ValidateString("]["));
            Assert.IsFalse(Solution.ValidateString("]"));
            Assert.IsFalse(Solution.ValidateString("["));
        }

    }
}

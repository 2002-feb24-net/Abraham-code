using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodNullorEmpty()
        {
            PalindromeLibrary palindromeLibrary = new PalindromeLibrary();
            string[] emptyNull = { string.Empty, null };

            foreach (var en in emptyNull)
            {
                bool result = palindromeLibrary.emptyNull(en);
                Assert.IsFalse(result, string.Format("Exptected for '{0}': false; actual: {1}", en, result));
            }
        }

        [TestMethod]
        public void IsPali()
        {
            PalindromeLibrary palindromeLibrary = new PalindromeLibrary();
            string[] emptyNull = { "a", "aabaa", "ababababa" };

            foreach (var en in emptyNull)
            {
                bool result = palindromeLibrary.paliTest(en);
                Assert.IsTrue(result, string.Format("Exptected for '{0}': false; actual: {1}", en, result));
            }
        }

        [TestMethod]
        public void IsNotPali()
        {
            PalindromeLibrary palindromeLibrary = new PalindromeLibrary();
            string[] emptyNull = { "ab", "aabaab", "ababababab" };

            foreach (var en in emptyNull)
            {
                bool result = palindromeLibrary.paliTest(en);
                Assert.IsFalse(result, string.Format("Exptected for '{0}': false; actual: {1}", en, result));
            }
        }
    }
}

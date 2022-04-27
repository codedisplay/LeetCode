using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SubstringWithConcatenationofAllWordsTests
    {
        [TestMethod]
        public void FindSubstring()
        {
            // TODO: tests
            var words = new string[] { "foo", "bar" };

            SubstringWithConcatenationofAllWords l = new SubstringWithConcatenationofAllWords();
            var x = l.FindSubstring("foobarfoothefoobarman", words);
            x = l.FindSubstring("barfoo", words);
            x = l.FindSubstring("foo", words);
            x = l.FindSubstring("foofoo", words);
            x = l.FindSubstring("foobarfoothefoobarman", words);
            x = l.FindSubstring("barfoothefoobarman", words);
            x = l.FindSubstring("foobar", words);
 
            words = new string[] { "" };
            x = l.FindSubstring("", words);

            words = new string[] { "bar", "foo", "the" };
            x = l.FindSubstring("barfoofoobarthefoobarman", words);

            words = new string[] { "ab", "ba", "ab", "ba" };
            x = l.FindSubstring("abaababbaba", words);
            //x = l.FindSubstring(s, words);
        }
    }
}

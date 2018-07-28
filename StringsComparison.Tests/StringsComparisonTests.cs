using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringsComparisonTests
{
    [TestClass]
    public class StringsComparisonTests
    {
        [TestMethod]
        public void CompareStrings_MatchingStrings()
        {
            double result = StringsComparison.CompareStrings("test", "test");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CompareStrings_PartialMatchingStrings()
        {
            double result = StringsComparison.CompareStrings("test", "test1");
            Assert.AreEqual(.8, result);
        }

        [TestMethod]
        public void CompareStrings_NoMatchStrings()
        {
            double result = StringsComparison.CompareStrings("test", "world");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CompareStrings_MultipleMatch()
        {
            double result = StringsComparison.CompareStrings("testtest", "test");
            Assert.AreEqual(.5, result);

            result = StringsComparison.CompareStrings("test", "testtest ");
            Assert.AreEqual(.5, result);
        }

        [TestMethod]
        public void CompareStrings_EmptyStrings()
        {
            double result = StringsComparison.CompareStrings("", "");
            Assert.AreEqual(0, result);
        }
    }
}

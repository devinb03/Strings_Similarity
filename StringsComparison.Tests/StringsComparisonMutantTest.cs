using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringsComparisonTests
{
    [TestClass]
    public class StringsComparisonMutantTests
    {
        [TestMethod]
        public void CompareStrings_MatchingStrings()
        {
            double result = StringsComparisonMutant.CompareStrings("test", "test");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CompareStrings_PartialMatchingStrings()
        {
            double result = StringsComparisonMutant.CompareStrings("test", "test1");
            Assert.AreEqual(.8, result);
        }

        [TestMethod]
        public void CompareStrings_NoMatchStrings()
        {
            double result = StringsComparisonMutant.CompareStrings("test", "world");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CompareStrings_MultipleMatch()
        {
            double result = StringsComparisonMutant.CompareStrings("testtest", "test");
            Assert.AreEqual(.5, result);

            result = StringsComparisonMutant.CompareStrings("test", "testtest ");
            Assert.AreEqual(.5, result);
        }

        [TestMethod]
        public void CompareStrings_EmptyStrings()
        {
            double result = StringsComparisonMutant.CompareStrings("", "");
            Assert.AreEqual(0, result);
        }
    }
}

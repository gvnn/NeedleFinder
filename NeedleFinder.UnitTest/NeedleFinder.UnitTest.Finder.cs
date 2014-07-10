using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NeedleFinder.UnitTest
{
    [TestClass]
    public class NeedleFinderApplication
    {
        [TestMethod]
        public void TestFinder()
        {
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            
            string result = NeedleFinder.Finder.GetMatchResult(text, "X", true);
            Assert.AreEqual("no matches", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "Polly", true);
            Assert.AreEqual("1, 26, 51", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "polly", true);
            Assert.AreEqual("1, 26, 51", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "Polly", false);
            Assert.AreEqual("1", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "polly", false);
            Assert.AreEqual("26, 51", result);

            result = NeedleFinder.Finder.GetMatchResult(text, string.Empty, false);
            Assert.AreEqual("no matches", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "PolX", false);
            Assert.AreEqual("no matches", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "ll", true);
            Assert.AreEqual("3, 28, 53, 78, 82", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "Ll", true);
            Assert.AreEqual("3, 28, 53, 78, 82", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "ll", false);
            Assert.AreEqual("3, 28, 53, 78, 82", result);

            result = NeedleFinder.Finder.GetMatchResult(text, "Ll", false);
            Assert.AreEqual("no matches", result);
        }
    }
}

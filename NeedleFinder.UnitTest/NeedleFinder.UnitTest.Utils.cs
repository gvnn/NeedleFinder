using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeedleFinder.Utils;

namespace NeedleFinder.UnitTest
{
    [TestClass]
    public class NeedleFinderUtils
    {
        [TestMethod]
        public void TestMatch()
        {
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

            int[] matches = text.Match("Polly", true);
            CollectionAssert.AreEqual(new int[] { 1, 26, 51 }, matches);

            matches = text.Match("polly", true);
            CollectionAssert.AreEqual(new int[] { 1, 26, 51 }, matches);

            matches = text.Match("Polly");
            CollectionAssert.AreEqual(new int[] { 1 }, matches);

            matches = text.Match("polly");
            CollectionAssert.AreEqual(new int[] { 26, 51 }, matches);

            matches = text.Match(string.Empty);
            CollectionAssert.AreEqual(new int[] { }, matches);

            matches = text.Match("X");
            CollectionAssert.AreEqual(new int[] { }, matches);

            matches = text.Match("PolX");
            CollectionAssert.AreEqual(new int[] { }, matches);

            matches = text.Match("ll", true);
            CollectionAssert.AreEqual(new int[] { 3, 28, 53, 78, 82 }, matches);

            matches = text.Match("Ll", true);
            CollectionAssert.AreEqual(new int[] { 3, 28, 53, 78, 82 }, matches);

            matches = text.Match("ll");
            CollectionAssert.AreEqual(new int[] { 3, 28, 53, 78, 82 }, matches);

            matches = text.Match("Ll");
            CollectionAssert.AreEqual(new int[] { }, matches);
        }
    }
}

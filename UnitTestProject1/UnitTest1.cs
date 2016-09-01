using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRLamb.StringUtils;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StrReturnsTrimmedString()
        {
            string test = "On    top of       spaghetti         ";
            Assert.AreEqual("On top of spaghetti", test.TrimInnerWhitespaceReplace());
        }
    }
}

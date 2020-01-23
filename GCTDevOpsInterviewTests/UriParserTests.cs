using System;
using GCTDevOpsInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCTDevOpsInterviewTests
{
    [TestClass]
    public class UriParserTests
    {
        [TestMethod]
        public void IsValid_GoogleDotCom()
        {
            string googleDotCom = "https://www.google.com";

            string expectedScheme = "https";
            string expectedHost = "www.google.com";
            string expectedPort = "";
            string expectedQuery = "";
            string expectedFragment = "";

            Assert.AreEqual(expectedScheme, GCTDevOpsInterview.UriParser.GetScheme(googleDotCom) ); 
        }

    }
}

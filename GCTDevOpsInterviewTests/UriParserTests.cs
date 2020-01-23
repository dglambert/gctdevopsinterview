using System;
using GCTDevOpsInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCTDevOpsInterviewTests
{
    [TestClass]
    public class UriParserTests
    {
        [TestMethod]
        public void GoogleDotCom_Valid_Scheme()
        {
            string googleDotCom = "https://www.google.com";

            string expectedScheme = "https";

            Assert.AreEqual( expectedScheme, GCTDevOpsInterview.UriParser.GetScheme(googleDotCom) );
        }

        [TestMethod]
        public void GoogleDotCom_Valid_Host()
        {
            string googleDotCom = "https://www.google.com";

            string expectedHost = "www.google.com";

            Assert.AreEqual(expectedHost, GCTDevOpsInterview.UriParser.GetHost(googleDotCom));
        }

        [TestMethod]
        public void GoogleDotCom_Valid_Path()
        {
            string googleDotCom = "https://www.google.com";

            string expectedPath = "";

            Assert.AreEqual(expectedPath, GCTDevOpsInterview.UriParser.GetPath(googleDotCom));
        }

        [TestMethod]
        public void GoogleDotCom_Valid_Port()
        {
            string googleDotCom = "https://www.google.com";

            string expectedPort = "";

            Assert.AreEqual(expectedPort, GCTDevOpsInterview.UriParser.GetPort(googleDotCom));
        }

        [TestMethod]
        public void GoogleDotCom_Valid_Query()
        {
            string googleDotCom = "https://www.google.com";

            string expectedQuery = "";

            Assert.AreEqual(expectedQuery, GCTDevOpsInterview.UriParser.GetQuery(googleDotCom));
        }

        [TestMethod]
        public void GoogleDotCom_Valid_Fragment()
        {
            string googleDotCom = "https://www.google.com";

            string expectedFragment = "";

            Assert.AreEqual(expectedFragment, GCTDevOpsInterview.UriParser.GetFragment(googleDotCom));
        }



    }
}

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







        [TestMethod]
        public void localhost80_Valid_Scheme()
        {
            string localhost80 = "http://localhost:80";

            string expectedScheme = "http";

            Assert.AreEqual(expectedScheme, GCTDevOpsInterview.UriParser.GetScheme(localhost80));
        }

        [TestMethod]
        public void localhost80_Valid_Host()
        {
            string localhost80 = "http://localhost:80";

            string expectedHost = "localhost";

            Assert.AreEqual(expectedHost, GCTDevOpsInterview.UriParser.GetHost(localhost80));
        }

        [TestMethod]
        public void localhost80_Valid_Path()
        {
            string localhost80 = "http://localhost:80";

            string expectedPath = "";

            Assert.AreEqual(expectedPath, GCTDevOpsInterview.UriParser.GetPath(localhost80));
        }

        [TestMethod]
        public void localhost80_Valid_Port()
        {
            string localhost80 = "http://localhost:80";

            string expectedPort = "80";

            Assert.AreEqual(expectedPort, GCTDevOpsInterview.UriParser.GetPort(localhost80));
        }

        [TestMethod]
        public void localhost80_Valid_Query()
        {
            string localhost80 = "http://localhost:80";

            string expectedQuery = "";

            Assert.AreEqual(expectedQuery, GCTDevOpsInterview.UriParser.GetQuery(localhost80));
        }

        [TestMethod]
        public void localhost80_Valid_Fragment()
        {
            string localhost80 = "http://localhost:80";

            string expectedFragment = "";

            Assert.AreEqual(expectedFragment, GCTDevOpsInterview.UriParser.GetFragment(localhost80));
        }








        [TestMethod]
        public void githubrepo_Valid_Scheme()
        {
            string githubrepo = "https://github.com/dglambert/gctdevopsinterview";

            string expectedScheme = "https";

            Assert.AreEqual(expectedScheme, GCTDevOpsInterview.UriParser.GetScheme(githubrepo));
        }

        [TestMethod]
        public void githubrepo_Valid_Host()
        {
            string githubrepo = "https://github.com/dglambert/gctdevopsinterview";

            string expectedHost = "github.com";

            Assert.AreEqual(expectedHost, GCTDevOpsInterview.UriParser.GetHost(githubrepo));
        }

        [TestMethod]
        public void githubrepo_Valid_Path()
        {
            string githubrepo = "https://github.com/dglambert/gctdevopsinterview";

            string expectedPath = "/dglambert/gctdevopsinterview";

            Assert.AreEqual(expectedPath, GCTDevOpsInterview.UriParser.GetPath(githubrepo));
        }

        [TestMethod]
        public void githubrepo_Valid_Port()
        {
            string githubrepo = "https://github.com/dglambert/gctdevopsinterview";

            string expectedPort = "";

            Assert.AreEqual(expectedPort, GCTDevOpsInterview.UriParser.GetPort(githubrepo));
        }

        [TestMethod]
        public void githubrepo_Valid_Query()
        {
            string githubrepo = "https://github.com/dglambert/gctdevopsinterview";

            string expectedQuery = "";

            Assert.AreEqual(expectedQuery, GCTDevOpsInterview.UriParser.GetQuery(githubrepo));
        }

        [TestMethod]
        public void githubrepo_Valid_Fragment()
        {
            string githubrepo = "https://github.com/dglambert/gctdevopsinterview";

            string expectedFragment = "";

            Assert.AreEqual(expectedFragment, GCTDevOpsInterview.UriParser.GetFragment(githubrepo));
        }

    }
}

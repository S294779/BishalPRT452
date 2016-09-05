using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramsPT452;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] a = { "how ", "who", "awp", "paw", "wap  ", "12as","as12" };
            AnagramChecker.CheckAnagramWords(a);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string[] b = { "cat ", "tac", "ac t", "i  nk", "nki  ", "pot" };
            AnagramChecker.CheckAnagramWords(b);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string[] c = { "egg ", "geg", "ant", "tna", "atn  ", "hot","gge" };
            AnagramChecker.CheckAnagramWords(c);
        }
    }
}

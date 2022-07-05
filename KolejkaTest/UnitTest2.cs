using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolejkaTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            /// assert
            /// 

            Assert.AreEqual("jeden", mapa[1]);
            Console.WriteLine(mapa[1]);

            Console.ReadKey();




        }
    }
}

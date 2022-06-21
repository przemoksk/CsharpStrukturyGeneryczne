using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _2_KolekcjeGenTest
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

            lista.Add(6);

            lista.Insert(1, 10);

            // Assert

            Assert.AreEqual(10, lista[1]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(5, lista.Count);
        }
    }
}

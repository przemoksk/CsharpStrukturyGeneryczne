using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolejkaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var kolejka = new Queue();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            //Assert

            Assert.AreEqual(1, kolejka.Peek());
        }
    }
}

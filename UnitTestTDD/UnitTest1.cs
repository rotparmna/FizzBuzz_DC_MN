using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFizz(int numero)
        {
            TDD.Program prueba = new TDD.Program();

            int x = prueba.DivisiblexTres(numero);

            //int x = numero % 3;
            Assert.AreEqual(0, x);
        }


    }
}

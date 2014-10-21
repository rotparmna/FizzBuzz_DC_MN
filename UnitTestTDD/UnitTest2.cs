using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestTDD
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void DivisiblexTres()
        {
            int valorActual = 0;
            int valorEsperado = 0;
            int numero = 3;

            TDD.Program prueba = new TDD.Program();
            valorActual = prueba.DivisiblexTres(numero);
            Assert.AreEqual(valorEsperado, valorActual);
        }

        [TestMethod]
        public void DivisiblexCinco()
        {
            int valorActual = 0;
            int valorEsperado = 0;
            int numero = 15;

            TDD.Program prueba = new TDD.Program();
            valorActual = prueba.DivisiblexCinco(numero);
            Assert.AreEqual(valorEsperado, valorActual);
        }

        [TestMethod]
        public void DivisiblexCincoyTres()
        {
            bool valorActual;
            bool valorEsperado = true;
            int numero = 15;

            TDD.Program prueba = new TDD.Program();
            
            valorActual = prueba.DivisiblexCincoyTres(numero);

            Assert.AreEqual(valorEsperado, valorActual);
        }

        [TestMethod]
        public void ValidarTotalidadNumeros()
        {
            TDD.Program prueba = new TDD.Program();
            List<string> total = prueba.Jugar();
            Assert.AreEqual(99, total.Count);
        }

        [TestMethod]
        public void ValidarFizz()
        {
            string valorEsperado = "Fizz";
            List<string> valorActual = new List<string>();
            TDD.Program prueba = new TDD.Program();
            valorActual = prueba.Jugar();

            Assert.AreEqual(valorEsperado, valorActual[2]);
        }

        [TestMethod]
        public void ValidarBuzz()
        {
            string valorEsperado = "Buzz";
            List<string> valorActual = new List<string>();
            TDD.Program prueba = new TDD.Program();
            valorActual = prueba.Jugar();

            Assert.AreEqual(valorEsperado, valorActual[4]);
        }

        [TestMethod]
        public void ValidarFizzBuzz()
        {
            string valorEsperado = "FizzBuzz";
            List<string> valorActual = new List<string>();
            TDD.Program prueba = new TDD.Program();
            valorActual = prueba.Jugar();

            Assert.AreEqual(valorEsperado, valorActual[14]);
        }
    }
}

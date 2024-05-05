using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            int esperado = 12;
            int actual = MCD.CalcularMCDCuatroNumeros(24, 36, 48, 60);
            Assert.AreEqual(esperado, actual);

            int esperado2 = 5;
            int actual2 = MCD.CalcularMCDCuatroNumeros(10, 5, 20, 25);
            Assert.AreEqual(esperado2, actual2);

            int esperado3 = 1;
            int actual3 = MCD.CalcularMCDCuatroNumeros(7, 5, 12, 8);
            Assert.AreEqual(esperado3, actual3);

            int esperado4 = 25;
            int actual4 = MCD.CalcularMCDCuatroNumeros(100, 75, 150, 200);
            Assert.AreEqual(actual4, esperado4);

            int esperado5 = 10;
            int actual5 = MCD.CalcularMCDCuatroNumeros(50, 20, 40, 60);
            Assert.AreEqual(actual5, esperado5);

        }
    }
}

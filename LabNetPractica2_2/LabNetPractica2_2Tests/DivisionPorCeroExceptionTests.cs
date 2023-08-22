using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivisionExceptionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DivisionExceptionExample.Tests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void TestDivisionValida()
        {
            // Arrange
            double dividendo = 10;
            double divisor = 2;

            // Act
            double resultado = Calculator.RealizarDivision(dividendo, divisor);

            // Assert
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivisionPorCeroException))]
        public void TestDivisionPorCero()
        {
            // Arrange
            double dividendo = 8;
            double divisor = 0;

            // Act
            Calculator.RealizarDivision(dividendo, divisor);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestEntradaInvalida()
        {
            // Arrange
            double dividendo = 10;
            string entradaDivisor = "abc";

            // Act
            double divisor = double.Parse(entradaDivisor);
            Calculator.RealizarDivision(dividendo, divisor);
        }
    }
}
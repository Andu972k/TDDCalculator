using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCalculator.Operations;

namespace TDDCalculatorTests
{
    [TestClass]
    public class DivisionTests
    {

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_Exception()
        {

            //Arrange

            int x = 30;
            int y = 0;



            //Act and Assert

            CalculatorOperations.Divide(x, y);

        }

        [TestMethod]
        public void Divide_ZeroAsDividend_Zero()
        {
            //Arrange

            int x = 0;
            int y = 6;

            double expectedResult = x / y;

            //Act

            double actualResult = CalculatorOperations.Divide(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }

        [TestMethod]
        public void Divide_TwoPositiveNumbers_PositiveQuotient()
        {
            //Arrange

            int x = 10;
            int y = 3;

            double expectedResult = x / y;

            //Act

            double actualResult = CalculatorOperations.Divide(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }


        [TestMethod]
        public void Divide_PositiveDividendNegativeDivisor_NegativeQuotient()
        {
            //Arrange

            int x = 25;
            int y = -6;

            double expectedResult = x / y;

            //Act

            double actualResult = CalculatorOperations.Divide(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }

        [TestMethod]
        public void Divide_NegativeDividendPositiveDivisor_NegativeQuotient()
        {
            //Arrange

            int x = -254;
            int y = 6;

            double expectedResult = x / y;

            //Act

            double actualResult = CalculatorOperations.Divide(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }

        [TestMethod]
        public void Divide_TwoNagativeNumbers_PositiveQuotient()
        {
            //Arrange

            int x = -100;
            int y = -16;

            double expectedResult = x / y;

            //Act

            double actualResult = CalculatorOperations.Divide(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }

    }
}

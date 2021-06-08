using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCalculator.Operations;

namespace TDDCalculatorTests
{
    [TestClass]
    public class MultiplicationTests
    {

        [TestMethod]
        public void Multiply_ByZero_Zero()
        {
            //Arrange

            int x = 694;
            int y = 0;

            int expectedResult = x * y;

            //Act

            int actualResult = CalculatorOperations.Multiply(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Multiply_TwoPositiveNumbers_TheProductOfTheNumbers()
        {
            //Arrange

            int x = 7;
            int y = 8;

            int expectedResult = x * y;

            //Act

            int actualResult = CalculatorOperations.Multiply(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void Multiply_OnePositiveAndOneNegativeNumber_ANegativeProduct()
        {
            //Arrange

            int x = 5;
            int y = -4;

            int expectedResult = x * y;

            //Act

            int actualResult = CalculatorOperations.Multiply(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Multiply_TwoNegativeNumbers_APositiveProduct()
        {
            //Arrange

            int x = -5;
            int y = -5;

            int expectedResult = x * y;

            //Act

            int actualResult = CalculatorOperations.Multiply(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}

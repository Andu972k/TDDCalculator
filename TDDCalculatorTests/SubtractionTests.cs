using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCalculator.Operations;

namespace TDDCalculatorTests
{
    [TestClass]
    public class SubtractionTests
    {

        [TestMethod]
        public void Subtract_SameNumber_Zero()
        {
            //Arrange

            int x = 9;

            int expectedResult = 0;

            //Act

            int actualResult = CalculatorOperations.Subtract(x, x);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_TwoPositiveNumbers_TheDifference()
        {
            //Arrange

            int x = 4;
            int y = 7;

            int expectedResult = x - y;

            //Act

            int actualResult = CalculatorOperations.Subtract(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_FirstNumberNegativeSecondNumberPositive_ANegativeNumber()
        {
            //Arrange

            int x = -13;
            int y = 7;

            int expectedResult = x - y;

            //Act

            int actualResult = CalculatorOperations.Subtract(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Subtract_FirstNumberPositiveSecondNumberNegative_APositiveNumber()
        {
            //Arrange

            int x = 16;
            int y = -7;

            int expectedResult = x - y;

            //Act

            int actualResult = CalculatorOperations.Subtract(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_TwoNegativeNumbers_TheDifference()
        {
            //Arrange

            int x = -42;
            int y = -30;

            int expectedResult = x - y;

            //Act

            int actualResult = CalculatorOperations.Subtract(x, y);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCalculator.Operations;

namespace TDDCalculatorTests
{
    [TestClass]
    public class AdditionTests
    {


        [TestMethod]
        public void Add_TwoPositiveNumbers_SumOfNumbers()
        {
            //Arrange

            int x = 5;
            int y = 43;
            int ExpectedSum = x + y;

            //Act

            int result = CalculatorOperations.Add(x, y);


            //Assert

            Assert.AreEqual(ExpectedSum, result);
        }

    }
}

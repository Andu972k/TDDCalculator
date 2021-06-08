using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCalculator.Calculator;

namespace TDDCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {

        [TestMethod]
        public void Calculate_Addition_SumOfNumbers()
        {
            //Arrange

            int x = 5;
            int y = 3;

            string equation = x + "+" + y;

            string expectedResult = $"= {x + y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        


        [TestMethod]
        public void Calculate_Subtraction_TheDifference()
        {
            //Arrange

            int x = 8;
            int y = 3;

            string equation = x + "-" + y;

            string expectedResult = $"= {x - y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Calculate_Multiplication_TheProduct()
        {
            //Arrange

            int x = 2;
            int y = 3;

            string equation = x + "*" + y;

            string expectedResult = $"= {x * y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Calculate_Division_TheQuotient()
        {
            //Arrange

            int x = 8;
            int y = 4;

            string equation = x + "/" + y;

            string expectedResult = $"= {x / y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_DivideByZero_Error()
        {
            //Arrange

            int x = 8;
            int y = 0;

            string equation = x + "/" + y;

            string expectedResult = "Can't divide by zero";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Calculate_AdditionWithNegativeNumbers_SumOfNumbers()
        {
            //Arrange

            int x = -5;
            int y = -3;

            string equation = x + "+" + y;

            string expectedResult = $"= {x + y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }





        [TestMethod]
        public void Calculate_SubtractionWithNegativeNumbers_TheDifference()
        {
            //Arrange

            int x = 8;
            int y = -3;

            string equation = x + "-" + y;

            string expectedResult = $"= {x - y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Calculate_MultiplicationWithNegativeNumbers_TheProduct()
        {
            //Arrange

            int x = -2;
            int y = -3;

            string equation = x + "*" + y;

            string expectedResult = $"= {x * y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Calculate_DivisionWithNegativeNumbers_TheQuotient()
        {
            //Arrange

            int x = -8;
            int y = 4;

            string equation = x + "/" + y;

            string expectedResult = $"= {x / y}";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Calculate_AllOperationsWithSpaces_CallsOperationsCorrectly()
        {
            //Arrange

            int x = 5;
            int y = 3;

            string addtionEquation = x + " " + "+" + " " + y;

            string addtionExpectedResult = $"= {x + y}";

            string subtractionEquation = x + " " + "-" + " " + y;

            string subtractionExpectedResult = $"= {x - y}";

            string multiplicationEquation = x + " " + "*" + " " + y;

            string multiplicationExpectedResult = $"= {x * y}";

            string divisionEquation = x + " " + "/" + " " + y;

            string divisionExpectedResult = $"= {x / y}";

            //Act

            string addtionActualResult = Calculator.Calculate(addtionEquation);

            string subtractionActualResult = Calculator.Calculate(subtractionEquation);

            string multiplicationActualResult = Calculator.Calculate(multiplicationEquation);

            string divisionActualResult = Calculator.Calculate(divisionEquation);

            //Assert

            Assert.AreEqual(addtionExpectedResult, addtionActualResult);
            Assert.AreEqual(subtractionExpectedResult, subtractionActualResult);
            Assert.AreEqual(multiplicationExpectedResult, multiplicationActualResult);
            Assert.AreEqual(divisionExpectedResult, divisionActualResult);
        }

        [TestMethod]
        public void Calculate_InvalidSigns_Error()
        {
            //Arrange

            int x = 8;
            int y = 4;

            string equation = x + "/" + "?" + y;

            string expectedResult = "Invalid Sign(s)";

            //Act

            string actualResult = Calculator.Calculate(equation);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}

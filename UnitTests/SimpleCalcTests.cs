using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;

namespace UnitTests
{
    [TestClass]
    public class SimpleCalcTests
    {
        //Addition Tests
        [TestMethod]
            public void TestAddMethodWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);
            
        }

        [TestMethod]
        public void TestAddMethodWithTwoNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = -8M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithFirstPositiveAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = -6M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithFirstNegativeAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = 8M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithFirstZeroAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 8M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithFirstZeroAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = -8M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithFirstPositiveAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 9M;
            decimal d2 = 0M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithFirstNegativeAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -9M;
            decimal d2 = 0M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithTwoZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 0M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestAddMethodWithTwoPositiveDecimalNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4.25M;
            decimal d2 = 8.25M;
            decimal expected = d1 + d2;
            decimal result = calculator.addition(d1, d2);
            Assert.AreEqual(expected, result);

        }

        // Subtract Tests

        [TestMethod]
        public void TestSubtractMethodWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithTwoNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = -8M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithFirstPositiveAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = -6M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithFirstNegativeAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = 8M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithFirstZeroAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 8M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithFirstZeroAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = -8M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithFirstPositiveAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 9M;
            decimal d2 = 0M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithFirstNegativeAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -9M;
            decimal d2 = 0M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithTwoZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 0M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestSubtractMethodWithTwoPositiveDecimalNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4.5M;
            decimal d2 = 8.5M;
            decimal expected = d1 - d2;
            decimal result = calculator.subtraction(d1, d2);
            Assert.AreEqual(expected, result);

        }



        //Multiplication Tests



        [TestMethod]
        public void TestMultiplyMethodWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithTwoNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = -8M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstPositiveAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = -6M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstNegativeAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = 8M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstZeroAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 8M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstZeroAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = -8M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstPositiveAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 9M;
            decimal d2 = 0M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstNegativeAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -9M;
            decimal d2 = 0M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithTwoZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 0M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMultiplyMethodWithTwoPositiveDecimalNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4.25M;
            decimal d2 = 8.25M;
            decimal expected = d1 * d2;
            decimal result = calculator.multiplication(d1, d2);
            Assert.AreEqual(expected, result);

        }


        //Divison Tests


        [TestMethod]
        public void TestDivisonMethodWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestDivisonMethodWithTwoNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = -8M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestDivisonMethodWithFirstPositiveAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = -6M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestDivisonMethodWithFirstNegativeAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -4M;
            decimal d2 = 8M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestDivisonMethodWithFirstZeroAndSecondPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 8M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestDivisonMethodWithFirstZeroAndSecondNegativeNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = -8M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestDivisonMethodWithFirstPositiveAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 9M;
            decimal d2 = 0M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);
            //error
        }

        [TestMethod]
        public void TestDivisonMethodWithFirstNegativeAndSecondZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = -9M;
            decimal d2 = 0M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);
            //error
        }

        [TestMethod]
        public void TestDivisonMethodWithTwoZeroNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 0M;
            decimal d2 = 0M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);
            //error
        }

        [TestMethod]
        public void TestDivisonMethodWithTwoPositiveDecimalNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4.25M;
            decimal d2 = 8.25M;
            decimal expected = d1 / d2;
            decimal result = calculator.divison(d1, d2);
            Assert.AreEqual(expected, result);

        }


        //Selection Method Tests

        [TestMethod]
        public void TestSelectionMethodAdditionWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            string operation = "Addition";
            decimal expected = d1 + d2;
            decimal result = calculator.OperatorSwitch(d1, d2, operation);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSelectionMethodSubtractionWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            string operation = "Subtraction";
            decimal expected = d1 - d2;
            decimal result = calculator.OperatorSwitch(d1, d2, operation);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSelectionMethodMultiplicationWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            string operation = "Multiplication";
            decimal expected = d1 * d2;
            decimal result = calculator.OperatorSwitch(d1, d2, operation);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSelectionMethodDivisonWithTwoPositiveNumbers()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 8M;
            string operation = "Division";
            decimal expected = d1 / d2;
            decimal result = calculator.OperatorSwitch(d1, d2, operation);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSelectionMethodDivisonWithZeroNumber()
        {
            SimpleCalc calculator = new SimpleCalc();
            decimal d1 = 4M;
            decimal d2 = 0M;
            string operation = "Division";
            decimal expected = d1 / d2;
            decimal result = calculator.OperatorSwitch(d1, d2, operation);
            Assert.AreEqual(expected, result);
        }



    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTDD;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_AddsTwoPositiveNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(2, 3);
            Assert.AreEqual(5, sum);
        }

        [TestMethod]
        public void Add_AddsPositiveAndNegativeNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(2, -3);
            Assert.AreEqual(-1, sum);
        }

        [TestMethod]
        public void Add_AddsTwoNegativeNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(-2, -3);
            Assert.AreEqual(-5, sum);
        }

        [TestMethod]
        public void Add_AddsNegativeAndPositiveNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(-2, 3);
            Assert.AreEqual(1, sum);
        }

        [TestMethod]
        public void Divide_TwoPositiveNumbers_Calculated()
        {
            var calc = new Calculator();
            float res = calc.Divide(4, 2);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Divide_NegativeAndPositiveNumbers_Calculated()
        {
            var calc = new Calculator();
            float res = calc.Divide(-4, 2);
            Assert.AreEqual(-2, res);
        }

        [TestMethod]
        public void Divide_PositiveAndNegativeNumbers_Calculated()
        {
            var calc = new Calculator();
            float res = calc.Divide(4, -2);
            Assert.AreEqual(-2, res);
        }

        [TestMethod]
        public void Divide_ZeroAndPositiveNumber_Calculated()
        {
            var calc = new Calculator();
            float res = calc.Divide(0, 3);
            Assert.AreEqual(0.0f, res);
        }

        [TestMethod]
        public void Divide_TwoPositiveNumbersReturnsFractial_Calculated()
        {
            var calc = new Calculator();
            float res = calc.Divide(5, 2);
            Assert.AreEqual(2.5f, res);
        }

        [TestMethod]
        public void Divide_TwoPositiveNumbersReturnsRoundedFractial_Calculated()
        {
            var calc = new Calculator();
            float res = calc.Divide(1, 3);
            Assert.AreEqual(0.333333343f, res);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DivisionByZero_ThrowsException()
        {
            var calc = new Calculator();
            calc.Divide(2, 0);
        }

        [TestMethod]
        public void Divide_OnCalculatedEventIsCalled()
        {
            var calc = new Calculator();

            bool wasEventCalled = false;
            calc.CalculatedEvent += (sender, args) => wasEventCalled = true;

            calc.Divide(1, 2);

            Assert.IsTrue(wasEventCalled);
        }

        //[TestCase(4, 2, 2.0f)]
        //[TestCase(-4, 2, -2.0f)]
        //[TestCase(4, -2, -2.0f)]
        //[TestCase(0, 3, 0.0f)]
        //[TestCase(5, 2, 2.5f)]
        //[TestCase(1, 3, 0.333333343f)]
        //public void Divide_ReturnsProperValue(int dividend, int divisor, float expectedQuotient)
        //{
        //    var calc = new Calculator();
        //    var quotient = calc.Divide(dividend, divisor);
        //    Assert.AreEqual(expectedQuotient, quotient);
        //}
    }
}

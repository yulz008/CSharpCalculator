using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass()]
    public class Tests
    { 
        [TestMethod()]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
           
            double a = 5;
            double b = 10;

            double result = calculator.Add(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(15, result);   
        }

        [TestMethod()]
        public void TestSubtract()
        {
            Calculator calculator = new Calculator();

            double a = 10;
            double b = 5;

            double result = calculator.Subtract(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void TestMultiply()
        {
            Calculator calculator = new Calculator();

            double a = 10;
            double b = 5;

            double result = calculator.Multiply(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(50, result);
        }

        [TestMethod()]
        public void TestDivide()
        {
            Calculator calculator = new Calculator();

            double a = 10;
            double b = 5;

            double result = calculator.Divide(a, b);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void TestDivideByZero()
        {
            Calculator calculator = new Calculator();

            double a = 10;
            double b = 0;

            try
            {
                double result = calculator.Divide(a, b);
            }
            catch (ArgumentException e)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert.Contains(e.Message,"Division by zero is not allowed");
                return;
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("No Exeption was thrown");
        }
    }
}
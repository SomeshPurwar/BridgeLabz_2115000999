using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace ProgramTest
{
    [TestFixture]
    public class Class1
    {
        private ArithmeticCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new ArithmeticCalculator();
        }

        [Test]
        public void TestAdd()
        {
            int expected = 30;
            int actual = calculator.Add(10,20);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestSubtract()
        {
            int expected = 30;
            int actual = calculator.Subtract(50, 20);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestMultiply()
        {
            int expected = 30;
            int actual = calculator.Multiply(3, 10);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestDivide1()
        {
            int expected = 30;
            int actual = calculator.Divide(900, 30);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestDivide2()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }

    }
}

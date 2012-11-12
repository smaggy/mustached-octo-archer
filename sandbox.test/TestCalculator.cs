using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using sandbox;

namespace sandbox.test
{
    [TestFixture]
    public class TestCalculator
    {
        [Test]
        public void test01()
        {
            Calculator calculator = new Calculator();
            int value = calculator.add(1, 2);
            Assert.AreEqual(3, value);
            System.Console.WriteLine("Testing console: the value is = " + value);
        }
        [Test]
        public void test02()
        {
            Calculator calculator = new Calculator();
            int value = calculator.subtract(4, 1);
            Assert.AreEqual(3, value);
        }
        [Test]
        public void test03()
        {
            Calculator calculator = new Calculator();
            int value = calculator.multiply(2, 2);
            Assert.AreEqual(4, value);
        }
        [Test]
        public void test04()
        {
            Calculator calculator = new Calculator();
            int value = calculator.add(1, 1);
            Assert.AreEqual(3, value);
        }
        [Test]
        public void test05()
        {
            Calculator calculator = new Calculator();
            int value = calculator.add(1, 1);
            Assert.AreNotEqual(2, value);
        }
        [Test]
        public void test06()
        {
            Calculator calculator = new Calculator();
            int value = calculator.add(1, 1);
            Assert.True(value < 2);
        }
        [Test]
        public void test07()
        {
            Calculator calculator = new Calculator();
            int value = calculator.add(1, 1);
            Assert.False(value > 1);
        }
    }
}

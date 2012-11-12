using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace sandbox.test
{
    [TestFixture]
    public class TestInheritanceExample
    {
        [Test]
        public void test01()
        {
            ExtendedClass extendedClass = new ExtendedClass();
            extendedClass.setName("This is my name.");
            Assert.AreEqual("This is my name.", extendedClass.getName());
            System.Console.WriteLine("from the extended class: " + extendedClass.getName());
        }
    }
}

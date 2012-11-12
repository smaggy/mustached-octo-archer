using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace sandbox.test
{
    [TestFixture]
    class TestAbstractFactory
    {
        [Test]
        public void test01()
        {
            ConcreteFactory1 f1 = new ConcreteFactory1();
            f1.createProductA().method01();
            f1.createProductB().method02();
        }
        [Test]
        public void test02()
        {
            ConcreteFactory2 f2 = new ConcreteFactory2();
            f2.createProductA().method01();
            f2.createProductB().method02();
        }
    }
}

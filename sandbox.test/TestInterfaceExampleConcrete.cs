using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace sandbox.test
{
    [TestFixture]
    public class TestInterfaceExampleConcrete
    {
        [Test]
        public void test01()
        {
            ConcreteInterfaceExample interfaceExampleConcrete = new ConcreteInterfaceExample();
            interfaceExampleConcrete.method01();
            interfaceExampleConcrete.method02();
            interfaceExampleConcrete.method03();
            interfaceExampleConcrete.method04();
        }
    }
}

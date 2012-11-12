using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace sandbox.test
{
    [TestFixture]
    public class TestCompositeExample
    {
        [Test]
        public void test01()
        {
            CompositeExample compositeExample = new CompositeExample();
            compositeExample.method01();
        }
    }
}

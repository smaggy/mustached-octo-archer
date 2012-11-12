using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sandbox
{
    public class ConcreteFactory2 : AbstractFactoryInterface
    {
        public AbstractProductAInterface createProductA()
        {
            return new ConcreteProductA2();
        }
        public AbstractProductBInterface createProductB()
        {
            return new ConcreteProductB2();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sandbox
{
    public class ConcreteFactory1 : AbstractFactoryInterface
    {
        public AbstractProductAInterface createProductA()
        {
            return new ConcreteProductA1();
        }
        public AbstractProductBInterface createProductB()
        {
            return new ConcreteProductB1();
        }
    }
}

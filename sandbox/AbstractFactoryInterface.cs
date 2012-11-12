using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sandbox
{
    public interface AbstractFactoryInterface
    {
        AbstractProductAInterface createProductA();
        AbstractProductBInterface createProductB();
    }
}

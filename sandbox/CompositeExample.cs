using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sandbox
{
    public class CompositeExample
    {
        private InterfaceExample01 _interfaceExample01;
        private InterfaceExample02 _interfaceExample02;

        public void method01()
        {
            this._interfaceExample01 = new ConcreteInterfaceExample();
            this._interfaceExample02 = new ConcreteInterfaceExample();
            this._interfaceExample01.method01();
            this._interfaceExample01.method02();
            this._interfaceExample02.method03();
            this._interfaceExample02.method04();
        }
    }
}

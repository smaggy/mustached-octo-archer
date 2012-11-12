using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sandbox
{
    public class ConcreteInterfaceExample : InterfaceExample01, InterfaceExample02
    {
        public void method01()
        {
            System.Console.WriteLine("InterfaceExampleConcrete|method01");
        }
        public void method02()
        {
            System.Console.WriteLine("InterfaceExampleConcrete|method02");
        }
        public void method03()
        {
            System.Console.WriteLine("InterfaceExampleConcrete|method03");
        }
        public void method04()
        {
            System.Console.WriteLine("InterfaceExampleConcrete|method04");
        }
    }
}

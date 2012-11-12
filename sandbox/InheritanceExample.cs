using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sandbox
{
    public class InheritanceExample
    {
        private string _name;

        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }
    }

    public class ExtendedClass : InheritanceExample
    {
        public string getName()
        {
            return this.Name;
        }

        public void setName(string value)
        {
            this.Name = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace sandbox.test
{
    [TestFixture]
    public class TestPlainOldCObject
    {
        [Test]
        public void test01()
        {
            PlainOldCObject poco = new PlainOldCObject();
            poco.IntObject = 3;
            Assert.AreEqual(3, poco.IntObject);
            System.Console.WriteLine("From the poco.IntObject: " + poco.IntObject);
        }
        [Test]
        public void test02()
        {
            PlainOldCObject poco = new PlainOldCObject();
            poco.BoolObject = true;
            Assert.AreEqual(true, poco.BoolObject);
            System.Console.WriteLine("From the poco.BoolObject: " + poco.BoolObject);
        }
        [Test]
        public void test03()
        {
            PlainOldCObject poco = new PlainOldCObject();
            poco.StringObject = "This is a new string input.";
            Assert.AreEqual("This is a new string input.", poco.StringObject);
            System.Console.WriteLine("From the poco.StringObject: " + poco.StringObject);
        }
        [Test]
        public void test04()
        {
            PlainOldCObject poco = new PlainOldCObject();
            poco.ListStringObject = new List<string>();
            poco.ListStringObject.Add("Item1");
            poco.ListStringObject.Add("Item2");
            poco.ListStringObject.Add("Item3");
            poco.ListStringObject.Add("Item4");
            Assert.NotNull(poco.ListStringObject);

            System.Console.WriteLine("From the poco.ListStringObject: ");
            foreach (String item in poco.ListStringObject) {
                System.Console.WriteLine("ListItem: " + item);
            }
        }
        [Test]
        public void test05()
        {
            PlainOldCObject poco = new PlainOldCObject();
            poco.CharObject = 'u';
            Assert.AreEqual('u', poco.CharObject);
            System.Console.WriteLine("From the poco.CharObject: " + poco.CharObject);
        }
        [Test]
        public void test06()
        {
            PlainOldCObject poco = new PlainOldCObject();
            poco.DateTimeObject = DateTime.Now;
            Assert.NotNull(poco.DateTimeObject);
            System.Console.WriteLine("From the poco.DateTimeObject: " + poco.DateTimeObject);
        }
    }
}

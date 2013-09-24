using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Test
{
    [TestClass]
    public class InterfaceDemo
    {
        interface IMyInterfaceA
        {
            void Foo();
        }

        interface IMyInterfaceB
        {
            bool Foo();
        }

        class MyClassA : IMyInterfaceA
        {
            public void Foo()
            {
            }
        }

       
        class MyClassB : IMyInterfaceA
        {
            void IMyInterfaceA.Foo()
            {
            }
        }

        class MyClassC : IMyInterfaceA, IMyInterfaceB
        {
            public void Foo()
            {
            }

            bool IMyInterfaceB.Foo()
            {
                return true;
            }

        }


        [TestMethod]
        public void TestMethod1()
        {
            new MyClassA().Foo();
            ((IMyInterfaceA)new MyClassB()).Foo();
            new MyClassC().Foo();
            ((IMyInterfaceB)new MyClassC()).Foo();
        }
    }
}

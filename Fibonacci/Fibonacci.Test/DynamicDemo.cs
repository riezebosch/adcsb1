using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Dynamic;

namespace Fibonacci.Test
{
    [TestClass]
    public class DynamicDemo
    {
        class Demo : DynamicObject
        {
            public override bool TryInvoke(InvokeBinder binder, object[] args, out object result)
            {
                return base.TryInvoke(binder, args, out result);
            }

            public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
            {
                return base.TryInvokeMember(binder, args, out result);
            }
        }

        class Demo2
        {
            public void Invoke(string name, params object[] args)
            {
            }
        }

        interface IMyInterface
        {
            void Foo();
        }

        class MyClass : IMyInterface
        {

            void IMyInterface.Foo()
            {
                Console.WriteLine("Foo!");
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            dynamic demo = new Demo();
            demo.VoerIetsUit();

            Demo2 demo2 = new Demo2();
            demo2.Invoke("VoerIetsUit");
        }

        [TestMethod]
        [ExpectedException(typeof(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException))]
        public void TestExplInterface()
        {
            dynamic demo = (IMyInterface)new MyClass();
            demo.Foo();
        }
    }
}

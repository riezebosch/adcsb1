using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    [TestClass]
    public class GenericsDemo
    {
        class Wrapper<LKJSDLKFJLKJSDLKFJSDF>
        {
            public LKJSDLKFJLKJSDLKFJSDF MyProperty { get; set; }

            public void Initialize(LKJSDLKFJLKJSDLKFJSDF input)
            {
                MyProperty = input;
            }

            public void ExtraGeneric<NOGEENPARAMETER>(LKJSDLKFJLKJSDLKFJSDF input, NOGEENPARAMETER weetikveel)
            {
            }

            public void ExtraGeneric2<LKJSDLKFJLKJSDLKFJSDF>(LKJSDLKFJLKJSDLKFJSDF input)
            {
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            var wrapper = new Wrapper<string>();
            wrapper.MyProperty = "hoi, whatever";

            wrapper.MyProperty.Substring(0, 23);

            var wrapper2 = new Wrapper<int>();
            wrapper2.MyProperty = 2 + 2;

            
        }

        [TestMethod]
        public void TestCollections()
        {
            var items = new ArrayList();
            items.Add(4);
            items.Add("vier");

        }
    }
}

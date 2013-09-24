using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Test
{
    // Generated Code
    partial class Class1
    {
        public string Name { get; set; }

        partial void DoSomethingPartial();

        public Class1()
        {
            DoSomethingPartial();
        }
    }

    // User generated code
    partial class Class1
    {
        public int Leeftijd { get; set; }
        partial void DoSomethingPartial()
        {

        }
    }

    [TestClass]
    public class AnonymousTypesAndInitializers
    {
        [TestMethod]
        public void MyTestMethod()
        {
            new Class1();
        }

        class Persoon
        {
            private string _naam;
            public string Naam 
            { 
                get 
                { 
                    return _naam; 
                } 
                set 
                { 
                    _naam = value; 
                } 
            }

            public int Leeftijd { get; set; }

            public Persoon(string naam, int leeftijd)
            {
                Naam = naam;
                Leeftijd = leeftijd;
            }

            public Persoon(int leeftijd)
            {
                Leeftijd = leeftijd;
            }

            public Persoon(string naam)
            {
                Naam = naam;
            }

            public Persoon()
            {

            }
        }

        [TestMethod]
        public void TestPersoon()
        {
            var persoon1 = new Persoon();
            persoon1.Naam = "Manuel Riezebosch";
            persoon1.Leeftijd = 31;

            var persoon2 = new Persoon()
            {
                Naam = "Manuel Riezebosch",
                Leeftijd = 31
            };

            var persoon3 = new Persoon("Manuel Riezebosch")
            {
                Naam = "Ezra Riezebosch",
                Leeftijd = 31
            };
        }

        [TestMethod]
        public void TestCollectionInitializer()
        {
            int[] items = { 1, 2, 32, 54, 234, 234 };
            var items2 = new[] { 2, 234, 234, 234, 234 };
            var items3 = new int[] { 234, 123, 123, };
            var items4 = new int[3] { 234, 123, 123, };
        }

        [TestMethod]
        public void TestAnonymousType()
        {
            var p = new
            {
                Leeftijd = 31,
                Voornaam = "Manuel",
                Achternaam = "Riezebosch"
            };
            Console.WriteLine(p.Voornaam);
        }

        [TestMethod]
        public void TestAnonymousTypeWithLinq()
        {
            var personen = new List<Persoon>
            {
                new Persoon { Naam = "Manuel Riezebosch", Leeftijd = 31 },
                new Persoon { Naam = "Ezra Riezebosch", Leeftijd = 3 }
            };

            var result = personen.
                Where(p => p.Leeftijd > 25).
                Select(p =>
                    new
                    {
                        NaamEnLeeftijd = p.Naam + ", " + p.Leeftijd,
                        p.Naam,
                        Original = p
                    }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.NaamEnLeeftijd);
            }

            personen.Add(new Persoon { Naam = "Jeffrey Stuij", Leeftijd = 19 });

            foreach (var item in result)
            {
                Console.WriteLine(item.NaamEnLeeftijd);
            }

        }
    }
}

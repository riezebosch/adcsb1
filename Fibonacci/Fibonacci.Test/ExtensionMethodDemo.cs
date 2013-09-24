using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Fibonacci.Test
{
    static class MyExtensions
    {
        public static IEnumerable<char> Vowels(this string input)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in input)
            {
                if (!vowels.Contains(item))
                {
                    yield return item;
                }
            }
        }


        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static void Print(this string input, int dummy)
        {
        }

        public static void Geheim(this Persoon persoon)
        {
            
        }
    }

    class Persoon
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        private int _secret;
    }

    [TestClass]
    public class ExtensionMethodDemo
    {
        [TestMethod]
        public void TestRemoveVowels()
        {
            var result1 = MyExtensions.Vowels("Manuel Riezebosch");
            var result2 = "Manuel Riezebosch".Vowels();
            
            foreach (var item in result2)
            {
                Console.Write(item);
            }
        }

        [TestMethod]
        public void TestPersoonExtensions()
        {
            var p = new Persoon();
            p.Geheim();
        }

        [TestMethod]
        public void TestFibonacciFilter()
        {
            Fibonacci.Reeks().Where(IsEven).OrderBy(Select).ThenBy(Select);
            
            Enumerable.ThenBy(Enumerable.OrderBy(Enumerable.Where(Fibonacci.Reeks(), IsEven), Select), Select);
        }

        private static bool IsEven(int item)
        {
            return item % 2 == 0;
        }

        private static int Select(int item)
        {
            return item;
        }


        [TestMethod]
        public void TestOrderBy()
        {
            var personen = new List<Persoon>
            {
                new Persoon { Naam = "Manuel Riezebosch", Leeftijd = 31 },
                new Persoon { Naam = "Ezra Riezebosch" , Leeftijd = 4 }
            };

            var result = personen.OrderBy(SorteerPersoon).ThenBy(SorteerDaarna);
            foreach (var item in result)
            {
                Console.WriteLine(item.Naam);
            }
        }

        private static string SorteerPersoon(Persoon p)
        {
            return p.Naam;
        }

        private static int SorteerDaarna(Persoon p)
        {
            return p.Leeftijd;
        }
    }
}
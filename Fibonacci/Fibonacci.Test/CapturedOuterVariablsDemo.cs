using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Test
{
    [TestClass]
    public class CapturedOuterVariablsDemo
    {
        class DoorgeefLuikje
        {
            public string input = "hallo, action";

            public void MijnEigenUitgeschrevenAnoniemeMethode()
            {
                Console.WriteLine(input);
            }

            public CapturedOuterVariablsDemo Parent { get; set; }
        }

        
        [TestMethod]
        public void TestMethod1()
        {
            string input = "manuel";
            var doorgeef = new DoorgeefLuikje() { Parent = this };
            Action a = () => Console.WriteLine(input);


            doorgeef.input = "input is in tussentijd toch wat anders geworden";
            Execute(doorgeef.MijnEigenUitgeschrevenAnoniemeMethode);
        }


        void Execute(Action a)
        {
            a();
        }

        [TestMethod]
        public void ShowMeTheDifferenceBetweenRefAndOut()
        {
            string input;// = "manuel";
            Print(out input);

            Console.WriteLine(input);
        }

        //private static void Print(ref string input)
        //{
        //    Console.WriteLine(input);
        //    input = "iets nieuws";
        //}

        private static void Print(out string input)
        {
            input = "Iets nieuws";
        }
    }
}

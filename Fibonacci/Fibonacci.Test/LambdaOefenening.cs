﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
namespace Fibonacci.Test
{
    [TestClass]
    public class LambdaOefenening
    {
        [TestMethod]
        public void LinqOefening()
        {
            var plaatsnamen = new List<string>
            { 
                "Amsterdam", "Arnhem", "Amersfoort",
                "Assen", "Amstelveen", "Alphen", "asdfm"
            };

            /* Opdracht 1;
             * Schrijf één LINQ-query (gebruikmakend van comprehension syntax / query syntax) 
             * die alle korte plaatsnamen (minder dan 8 letters), in volgorde van lengte, en 
             * bij gelijke lengte alfabetisch, oplevert.

             * Opdracht 2. 
             * Schrijf één LINQ-query (gebruikmakend van extension methods / fluent syntax) 
             * die de som bepaalt van de lengtes van alle plaatsnamen die eindigen 
             * op een ‘m’. 
             * (Met één LINQ-query wordt hier een aaneengesloten reeks van extension methods / query operators bedoeld.)

            
             * Opdracht 3. 
             * Bepaal met behulp van LINQ de meest voorkomende eindletter 
             * van de plaatsnamen. Het antwoord is een lijstje dat bestaat uit één element 
             * als er precies één eindletter het vaakst voorkomt, en bestaat uit meerdere 
             * letters als er meerdere eindletters een eerste plaats delen. 
             * Je oplossing mag bestaan uit meerdere queries en/of LINQ-expressies.
             */
            var result = (from p in plaatsnamen
                          group p by p.Last() into g
                          group g by g.Count() into g
                          orderby g.Key descending
                          select g).FirstOrDefault();

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}

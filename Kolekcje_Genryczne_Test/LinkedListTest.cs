using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kolekcje_Genryczne_Test
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void DodawaniePoElemencie()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddFirst("Manio");
            lista.AddAfter(lista.First, "AGA");

            Assert.AreEqual("AGA", lista.First.Next.Value);
        }

        [TestMethod]
        public void DodawaniePrzedElementem()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddFirst("Manio");
            lista.AddBefore(lista.First, "AGA");

            Assert.AreEqual("AGA", lista.First.Value);
        }

        [TestMethod]
        public void UsowanieOstatniegoelementu()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddFirst("Manio");

            lista.RemoveLast();

            Assert.AreEqual(lista.First, lista.Last);

        }
        [TestMethod]
        public void UsowanieElementu()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddFirst("Manio");

            lista.Remove("Marcin");

            Assert.AreEqual("Manio",lista.First.Value);

        }

        [TestMethod]
        public void CzyListaZawiera()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddFirst("Manio");

            Assert.IsTrue(lista.Contains("Manio"));

        }
        [TestMethod]
        public void CzyszczenieListya()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddFirst("Manio");

            lista.Clear();

            Assert.AreEqual(0,lista.Count);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kolekcje_Genryczne_Test
{
    [TestClass]
    public class DictionaryTest1
    {
        [TestMethod]
        public void UzywamyYSlownikJakomapy()

        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");

            Assert.AreEqual("jeden",mapa[1]);

        }
        [TestMethod]
        public void UWyszukiwanieWSlowniku()

        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");

            Assert.IsTrue(mapa.ContainsKey(3));
        }
        [TestMethod]
        public void UWyszukiwanieWSlownikuValeu()

        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");

            Assert.IsTrue(mapa.ContainsValue("jeden"));
        }
        [TestMethod]
        public void UsowanieElementuWSlowniku()

        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");
            mapa.Remove(1);

            Assert.AreEqual(3, mapa.Count);
        }
        [TestMethod]
        public void UsowanieElementOw()

        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");
            mapa.Clear();

            Assert.AreEqual(0, mapa.Count);
        }

        [TestMethod]
        public void SlownikWSlowniku()

        {
            var mapa = new Dictionary<string,string>();

            mapa.Add("one", "jeden");
            mapa.Add("two", "dwa");
            mapa.Add("three", "trzy");
            mapa.Add("Four", "cztery");
           
            Assert.AreEqual("jeden", mapa["one"]);

        }

        
        
    }
}

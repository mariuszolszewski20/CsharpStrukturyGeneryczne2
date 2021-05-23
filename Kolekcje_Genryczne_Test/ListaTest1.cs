using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolekcje_Genryczne_Test
{
    [TestClass]
    public class ListaTest1
    {
        [TestMethod]
        public void LisatMozemyDodawacNaKOniec()
        {
            List<int> listaliczb = new List<int> { 1, 2, 3 };
            listaliczb.Add(4);

            Assert.AreEqual(4, listaliczb[3]);
        }

        [TestMethod]
        public void LisatMozemyDodawacNaPozycji()
        {
            List<int> listaliczb = new List<int> { 1, 2, 3 };
            listaliczb.Insert(1,8);

            Assert.AreEqual(8, listaliczb[1]);

        }

        [TestMethod]
        public void LisatMozemyUsowacElement()
        {
            List<int> listaliczb = new List<int> { 1, 4, 3 };
            listaliczb.Remove(4);

            Assert.IsTrue(listaliczb.SequenceEqual(new[] { 1, 3 }));

        }

        [TestMethod]
        public void LisatMozemyUsowacElementNaPozycji()
        {
            List<int> listaliczb = new List<int> { 1, 2, 3 };
            listaliczb.RemoveAt(2);

            Assert.IsTrue(listaliczb.SequenceEqual(new[] { 1,2 }));

        }

        [TestMethod]
        public void CzyMozemyWyszukazIdeksu()
        {
            List<int> listaliczb = new List<int> { 1, 2, 3 };
            

            Assert.AreEqual(listaliczb.IndexOf(3),2);

        }

        [TestMethod]
        public void CzyMozemyWyszukaczyZawiera()
        {
            List<int> listaliczb = new List<int> { 1, 2, 3 };


            Assert.IsTrue(listaliczb.Contains(3));

        }

        [TestMethod]
        public void ListaZakres()
        {
            List<int> listaliczb = new List<int> { 1, 2, 3 };
            var zakres= new List<int> { 4, 5, 6 };

            listaliczb.AddRange(zakres);

            Assert.AreEqual(6, listaliczb[5]);
        }
    }
}

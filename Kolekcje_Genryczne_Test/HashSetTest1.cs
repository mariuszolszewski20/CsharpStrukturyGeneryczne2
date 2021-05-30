using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kolekcje_Genryczne_Test
{
    [TestClass]
    public class HashSetTest1
    {
        [TestMethod]
        public void IntersectWithPorównanieCzesciWspolejZbioru()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        [TestMethod]
        public void UnionWithPolaczenieZbiorow()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }
        [TestMethod]
        public void SymmetricExceptWithZnalezienieCzesciSpozaZbioru()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }
        [TestMethod]
        public void RemoveSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.Remove(1);
            Assert.AreEqual(2, set1.Count);
        }
        [TestMethod]
        public void RemoveWherePodajemyWarunek()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.RemoveWhere(x => x > 1);
            Assert.AreEqual(2, set1.Count);
        }

            [TestMethod]
            public void ContainsCzyzawiera()
            {
                var set1 = new HashSet<int>() { 1, 2, 3 };
                

              
                Assert.IsTrue(set1.Contains(3));

            }

        }
}

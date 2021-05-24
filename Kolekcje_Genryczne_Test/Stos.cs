using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kolekcje_Genryczne_Test
{
    [TestClass]
    public class Stos
    {
        [TestMethod]
       
            public void UzyciePeekZwracaPierwszyElement()
            {
                var stos = new Stack<int>();

                stos.Push(1);
                stos.Push(2);
                stos.Push(3);
                stos.Push(4);
                

                Assert.AreEqual(4, stos.Peek());

            }
        [TestMethod]
        public void UzycieConteinsCzyZawiera()
        {
            var stos = new Stack<int>();

            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            Assert.IsTrue(stos.Contains(3));

        }
        [TestMethod]

        public void UzycieTooArrayConventorowaniedoTablicy()
        {
            var stos = new Stack<int>();

            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            var tablica = stos.ToArray();
            stos.Pop();


            Assert.AreEqual(4, tablica[0]);
            Assert.AreEqual(3, stos.Count);



        }

        [TestMethod]
        public void UzycieClear()
        {
            var stos = new Stack<int>();

            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4); ;

            stos.Clear();

            Assert.AreEqual(0, stos.Count);

        }

    }
}

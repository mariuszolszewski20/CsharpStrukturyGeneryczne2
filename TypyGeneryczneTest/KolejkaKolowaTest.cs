
using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypyGeneryczneTest
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        [TestMethod]
        public void KolejkaKolowaPusta()
        {
            var kolejka = new KolejkaKlowa();
            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void KolejkaTrzyElementowaJestPelna()
        {
            var kolejka = new KolejkaKlowa(pojemnosc:3);
            kolejka.Zapisz(3.8);
            kolejka.Zapisz(4.8);
            kolejka.Zapisz(5.2);
            Assert.IsTrue(kolejka.JestPelny);
        
           
        }

        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKlowa(pojemnosc: 3);
            var wartosc1 = 4.6;
            var wartosc2= 3.7;
            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);


        }
        [TestMethod]
        public void NadpisujeGdyJestWiekszaNizPojemnosc()

        {
            var kolejka = new KolejkaKlowa(pojemnosc: 3);
            var wartosci = new[] { 1.2, 3.4, 6, 7, 8, 9.1 };
            foreach (var wartosc in wartosci)
            {
                kolejka.Zapisz(wartosc);
            }

            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
            
            Assert.IsTrue(kolejka.JestPusty);


        }
    }
}

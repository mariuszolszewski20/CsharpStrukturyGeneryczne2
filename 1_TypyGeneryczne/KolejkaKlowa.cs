using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    public class KolejkaKlowa
    {
        private double[] bufor;
        private int poczatekbufora;
        private int koniecbufora;

        public KolejkaKlowa() : this(pojemnosc: 5)
        {

        }
        public KolejkaKlowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatekbufora = 0;
            koniecbufora = 0;

        }

        public void Zapisz(double wartosc)
        {
            bufor[koniecbufora] = wartosc;
            koniecbufora = (koniecbufora + 1) % bufor.Length;
            if (koniecbufora == poczatekbufora)
                poczatekbufora = (poczatekbufora + 1) % bufor.Length;
        }

        public double Czytaj()
        {
            var wynik = bufor[poczatekbufora];
            poczatekbufora = (poczatekbufora + 1) % bufor.Length;
            return wynik;

        }
        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }
        public bool JestPusty
        {
            get
            {
                return koniecbufora == poczatekbufora;
            }
        }
        public bool JestPelny
        {
            get
            {
                return (koniecbufora + 1) % bufor.Length == poczatekbufora;
            }
        }
    }
}

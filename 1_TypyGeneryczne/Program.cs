using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKlowa<double>(pojemnosc:3);
            var kolejkaInt = new KolejkaKlowa<int>();
            var kolejkaString = new KolejkaKlowa<string>(1000);
            var kolejkaOsob = new KolejkaKlowa<osoba>();

            kolejkaOsob.Zapisz(new osoba { Imie = "Stasiu", Nazwisko = "Nowak" });
            kolejkaOsob.Zapisz(new osoba { Imie = "Henio", Nazwisko = "Nowak" });
            kolejkaOsob.Zapisz(new osoba { Imie = "Basia", Nazwisko = "Nowak" });
            kolejkaOsob.Zapisz(new osoba { Imie = "Zbysio", Nazwisko = "Nowak" });

            while (!kolejkaOsob.JestPusty)
            {
                var wynik=kolejkaOsob.Czytaj().Imie;
                Console.WriteLine(wynik);


            }

            //while (true)
            //{
            //    var wartosc = 0.0;
            //    var wartoscWejsciowa = Console.ReadLine();
            //    if (double.TryParse(wartoscWejsciowa, out wartosc))
            //    {
            //        kolejka.Zapisz(wartosc);
            //        continue;
                
            //    }
            //    break;

            //}

            
            //var suma = 0.0;

            //Console.WriteLine("W naszej kolejce jest : ");

            //while (!kolejka.JestPusty)
            //{
            //    suma+= kolejka.Czytaj();
                
            
            //}
            //Console.WriteLine(suma);
        }
        public class osoba
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }

        }
    }
}

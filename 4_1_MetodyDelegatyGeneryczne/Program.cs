using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_MetodyDelegatyGeneryczne
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Delegaty dzialajace bez Conventer
            //Action<bool> drukuj = x => Console.WriteLine(x);
            //Func<double, double> potegowanie = d => d * d;
            //Func<double, double,double> dodaj = (x,y) => (x+y);
            //Predicate<double> jestMniejszeOdSto = d => d < 100;
            //drukuj(jestMniejszeOdSto(potegowanie(dodaj(11, 3))));

            
        


            var kolejka = new KolejkaKlowa<double>();
            
            WprowadznieDanych(kolejka);

            

            var jakoData = kolejka.Mapuj( d => new DateTime(2018, 01, 01).AddDays(d));
           
            foreach (var item in jakoData)
            {
                Console.WriteLine(item);
            }
           
            kolejka.Drukuj(d => Console.WriteLine(d)); 
            
            PrzewtwarzanieDanych(kolejka);

        }
     


        private static void PrzewtwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;

            Console.WriteLine("W naszej kolejce jest : ");

            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();

            }

            Console.WriteLine(suma);
        }


        private static void WprowadznieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();
                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;

                }
                break;

            }
        }


    }
}

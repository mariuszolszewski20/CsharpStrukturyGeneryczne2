using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolejka();

            //Console.WriteLine("  ");
            //Stos();

            HashSet();

        }

        private static void HashSet()
        {
            HashSet<Pracownik> set = new HashSet<Pracownik>();

            var pracownik = new Pracownik { Imie = "Mariusz" };
            set.Add(pracownik);
            set.Add(pracownik);

            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Henio", Nazwisko = "Spejson" });
            stos.Push(new Pracownik { Imie = "Maromek", Nazwisko = "Puczyk" });
            stos.Push(new Pracownik { Imie = "Aga", Nazwisko = "Kuczka" });


            Console.WriteLine("STOS");
            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + "   " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Henio", Nazwisko = "Spejson" });
            kolejka.Enqueue(new Pracownik { Imie = "Maromek", Nazwisko = "Puczyk" });
            kolejka.Enqueue(new Pracownik { Imie = "Aga", Nazwisko = "Kuczka" });

            Console.WriteLine("kolejka");


            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + "   " + pracownik.Nazwisko);
            }
        }
    }

}

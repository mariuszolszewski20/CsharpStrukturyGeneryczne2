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
            // HashSet();
            //  LinkedList();
            // LinkedList2();

            // Dictionary();

            // SortedDictionary();
            // SortedList();

            var set = new SortedSet<int>();
            set.Add(8);
            set.Add(6);
            set.Add(4);
            set.Add(3);
            set.Add(2);
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            var set1 = new SortedSet<string>();
            set1.Add("Pan");
            set1.Add("Jan");
            set1.Add("Fan");
            set1.Add("Kan");
            


            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(3, "Czy");
            listaPosortowana.Add(2, "dwa");
            listaPosortowana.Add(4, "sztery");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>();
            pracownicy.Add("Sprzedarz", new List<Pracownik> { new Pracownik { Imie="Jan",Nazwisko = "Nowak" },
                                                          new Pracownik { Imie="Koan",Nazwisko = "Kowal" },
                                                          new Pracownik { Imie="Bartosz",Nazwisko = "Olszski" }});

            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie="Jan",Nazwisko = "Nowak" },
                                                          new Pracownik { Imie="Burek",Nazwisko = "Olewski" }});


            pracownicy.Add("Ksiegowosc", new List<Pracownik> { new Pracownik { Imie="Henryk",Nazwisko = "Kowak" },
                                                              new Pracownik { Imie="Stach",Nazwisko = "Powal" },
                                                          new Pracownik { Imie="Ignac",Nazwisko = "Kszal" },
                                                          new Pracownik { Imie="Manio",Nazwisko = "Olszewski" }});
            foreach (var item in pracownicy)
            {
                Console.WriteLine("ilość pracowników w dziale {0}  wynosi  {1}", item.Key, item.Value.Count);
            }
        }

        private static void Dictionary()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik> { new Pracownik { Nazwisko = "Nowak" },
                                                          new Pracownik { Nazwisko = "Kowal" },
                                                          new Pracownik { Nazwisko = "Olszewski" }});


            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });



            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Nazwisko = "Powolnik" },
                                                          new Pracownik { Nazwisko = "BrakCzasu" }});



            foreach (var item in pracownicy)


            {

                Console.WriteLine("Dzial : " + item.Key);
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }
                Console.WriteLine();

            }

            Console.WriteLine("Pracownicy z Ksiegowosci");
            foreach (var item in pracownicy["Ksiegowosc"])

            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var elementPierwszy = lista.First;
            var elementOstatni = lista.Last;

            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            var wezel = lista.First;
            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
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

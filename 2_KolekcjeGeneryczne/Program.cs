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
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Henio", Nazwisko = "Spejson" });
            kolejka.Enqueue(new Pracownik { Imie = "Maromek", Nazwisko = "Puczyk" });
            kolejka.Enqueue(new Pracownik { Imie = "Aga", Nazwisko = "Kuczka" });

            while (kolejka.Count>0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie+"   "+pracownik.Nazwisko);
            }
                
        }
    }

}

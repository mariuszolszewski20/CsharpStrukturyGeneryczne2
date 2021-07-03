using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Dział_Kolekcja: SortedDictionary<string, SortedSet<Pracownik>>
    {
        public Dział_Kolekcja Add(string nazwaDziału,Pracownik pracownik)
        {
            if (!ContainsKey(nazwaDziału))
            { 
                Add(nazwaDziału, new SortedSet<Pracownik>(new PracownikComparer()));

            }
            this[nazwaDziału].Add(pracownik);
            return this;
        }
    }
}

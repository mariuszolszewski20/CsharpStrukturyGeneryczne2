using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _2_KolekcjeGeneryczne
{
    class PracownikComparer : IEqualityComparer<Pracownik>,IComparer<Pracownik>
    {
        public int Compare( Pracownik x, Pracownik y)
        {
            return string.Compare(x.Nazwisko, y.Nazwisko);
        }

        public bool Equals( Pracownik x,  Pracownik y)
        {
            return string.Equals(x.Nazwisko,y.Nazwisko);
        }

        public int GetHashCode( Pracownik obj)
        {
            return obj.Nazwisko.GetHashCode();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_MetodyDelegatyGeneryczne
{
    internal class KolejkaKlowa<T>
    {
        public KolejkaKlowa()
        {
            private int _pojemnosc;

        public KolejkaKlowa(int pojemnosc = 5)
        {
            _pojemnosc = pojemnosc;
        }
        public override void Zapisz(T wartosc)
        {
            base.Zapisz(wartosc);
            if (kolejka.Count > _pojemnosc)
            {
                kolejka.Dequeue();
            }
        }
        public override bool JestPelny
        {
            get
            {
                return kolejka.Count == _pojemnosc;
            }
        }
    }
    }
}
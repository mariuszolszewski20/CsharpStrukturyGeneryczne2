using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_KlasyInterfejsyGeneryczne
{
    
   
    public class KolejkaKlowa<T> : DuzaKolejka<T>
    {
        private int _pojemnosc;

        public KolejkaKlowa(int pojemnosc=5)
        {
            _pojemnosc = pojemnosc;
        }
        public override void Zapisz(T wartosc)
        {
            base.Zapisz(wartosc);
            if (kolejka.Count>_pojemnosc)
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

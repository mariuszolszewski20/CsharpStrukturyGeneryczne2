using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_MetodyDelegatyGeneryczne


{

    
    public static class KolejkaExtensions
    {
        public static IEnumerable<Twyjscie> Mapuj<T,Twyjscie>(this IKolejka<T>kolejka,Converter<T, Twyjscie> konwenter)
        {

            return kolejka.Select(i => konwenter(i));
        }

        public static void   Drukuj<T>(this IKolejka<T> kolejka,Action<T> wydruk)
            {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }

            }
    }
}

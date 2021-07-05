﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_MetodyDelegatyGeneryczne


{

    public delegate void Drukarka<T>(T dane);
    public static class KolejkaExtensions
    {
        public static IEnumerable<Twyjscie> ElementJako<T,Twyjscie>(this IKolejka<T>kolejka)
        {
            
            var konwerter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return (Twyjscie)wynik;
            }
        }

        public static void   Drukuj<T>(this IKolejka<T> kolejka,Drukarka<T> wydruk)
            {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }

            }
    }
}

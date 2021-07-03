namespace _4_MetodyDelegatyGeneryczne
{
    internal interface IKolejka<T>
    {
        public interface IKolejka<T> : IEnumerable<T>
        {
            bool JestPelny { get; }
            bool JestPusty { get; }

            T Czytaj();
            void Zapisz(T wartosc);
        }
    }
}
namespace UygulamaCalismalari_4
{
    public class PressMakinesi : IMakine
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        public void Bakim()
        {
            Console.WriteLine("Press Makinesi bakıma alındı.");
        }

        public void Calis()
        {
            Console.WriteLine("Press Makinesi çalışıyor.");
        }

        public void Dur()
        {
            Console.WriteLine("Press Makinesi durdu :(");
        }

        public void ParcaDegistir()
        {
            Console.WriteLine("Press Makinesi söktük.");
        }
    }
}

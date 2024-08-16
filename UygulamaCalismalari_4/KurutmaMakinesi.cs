namespace UygulamaCalismalari_4
{
    public class KurutmaMakinesi : IMakine
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        public void Bakim()
        {
            Console.WriteLine("Kurutma Makinesi bakıma alındı.");
        }

        public void Calis()
        {
            Console.WriteLine("Kurutma Makinesi çalışıyor.");
        }

        public void Dur()
        {
            Console.WriteLine("Kurutma Makinesi durdu :(");
        }

        public void ParcaDegistir()
        {
            Console.WriteLine("Kurutma Makinesi söktük.");
        }
    }
}

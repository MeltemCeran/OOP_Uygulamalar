namespace UygulamaCalismalari_4
{
    public class Matbaa : IMakine
    {
        public string Ad { get; set ; }
        public int Fiyat { get; set ; }

        public void Bakim()
        {
            Console.WriteLine("Matbaa bakıma alındı.");
        }

        public void Calis()
        {
            Console.WriteLine("Matbaa çalışıyor.");
        }

        public void Dur()
        {
            Console.WriteLine("Matbaa durdu :(");
        }

        public void ParcaDegistir()
        {
            Console.WriteLine("Matbaa söktük.");
        }
    }
}

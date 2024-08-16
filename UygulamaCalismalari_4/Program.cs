namespace UygulamaCalismalari_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("selam");

            Matbaa matbaa = new Matbaa();

            Console.WriteLine(matbaa.Ad = "Matbaa123"); 
            Console.WriteLine(matbaa.Fiyat = 1000000); 

            matbaa.Bakim();

            Console.WriteLine(new string('-',20));

            PressMakinesi pressMakinesi = new PressMakinesi();

            Console.WriteLine(pressMakinesi.Ad = "PM900");
            Console.WriteLine(pressMakinesi.Fiyat = 3);

            pressMakinesi.ParcaDegistir();

            Console.WriteLine(new string('-', 20));

            KurutmaMakinesi kurutmaMakinesi = new KurutmaMakinesi();

            Console.WriteLine(kurutmaMakinesi.Ad = "uuh");
            Console.WriteLine(kurutmaMakinesi.Fiyat = 50);

            kurutmaMakinesi.Dur();

            kurutmaMakinesi.Calis();




        }
    }
}

namespace UygulamaCalismalari_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi("meltem", "ceran", 1.68, "KADIN");
            Console.WriteLine($"ad {kisi.Ad}, soyad {kisi.Soyad}, boy {kisi.Boy}, cinsiyet {kisi.Cinsiyet}");

            Console.WriteLine("----------");


        }
    }
}

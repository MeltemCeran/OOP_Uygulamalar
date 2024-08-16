namespace UygulamaCalismalari_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Kopek kopek = new Kopek();

            kopek.Ad = "Rasta";
            kopek.Cins = "Golden Retriever";
            kopek.Cinsiyet = "ErKEK";
            kopek.YasadigiYer = "sdfg";
            kopek.Ses();
            kopek.BilgileriYaz();
            kopek.GetKopek();

            Console.WriteLine("---------");

            Kedi kedi = new Kedi();

            kedi.Ad = "Firuze";
            kedi.Cins = "Van Kedisi";
            kedi.Cinsiyet = "Dişi";
            kedi.YasadigiYer = "Ibiza";
            kedi.Ses();
            kedi.BilgileriYaz();
            kedi.GetKedi();
        }
    }
}

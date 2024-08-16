namespace UygulamaCalismalari_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insan ınsan1 = new Insan();

            //ınsan1.BilgileriAl();
            //ınsan1.BilgileriGoster();


            Memur memur1 = new Memur();

            memur1.BilgileriAl();
            memur1.BilgileriGoster();

            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.BilgileriAl();
            ogrenci1.BilgileriGoster();

            Akademisyen akademisyen1 = new Akademisyen();

            akademisyen1.BilgileriAl();
            akademisyen1.BilgileriGoster();

        }
    }
}


namespace UygulamaCalismalari_7
{
    public class Araba : ITasit
    {
        public string Plaka { get; set ; }
        public string Marka { get; set ; }
        public string Model { get ; set ; }
        public int UretimYili { get ; set ; }
        List<IParca> ITasit.parcaListesi { get ; set ; }

        public void Dur()
        {
            Console.WriteLine("Araba gidiyor");
        }

        public void Git()
        {
            Console.WriteLine("Araba durdu");
        }


    }
}

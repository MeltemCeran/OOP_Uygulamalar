
namespace UygulamaCalismalari_7
{
    public class Otobüs : ITasit
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int UretimYili { get; set; }
        public List<IParca> parcaListesi { get; set; }

        public void Dur()
        {
            Console.WriteLine("Otobüs gidiyor");
        }

        public void Git()
        {
            Console.WriteLine("Otobüs durdu");
        }
    }
}

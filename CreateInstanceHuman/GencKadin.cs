using CreateInstanceHuman.Concrete;

namespace CreateInstanceHuman
{
    public sealed class GencKadin : Kadın
    {
        public GencKadin(string adi, string ırkı, string dogduguYer, string turu) : base(adi, ırkı, dogduguYer, turu)
        {
        }

        public override void KekYap()
        {
            Console.WriteLine("Haşhaşlı kek yapıyorum.");
        }

    }
}

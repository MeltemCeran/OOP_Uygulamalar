namespace CreateInstanceHuman.Concrete
{
    public class Kadın : Varlik, IHuman
    {
        public Kadın(string adi, string ırkı, string dogduguYer, string turu) : base(adi, ırkı, dogduguYer, turu)
        {
        }

        public int KolSayisi
        {
            get { return 2; }
        }
        public int BacakSayisi
        {
            get { return 2; }
        }

        public void CisYap()
        {
            Console.WriteLine("Ayakta çiş yapamaz.");
        }

        public void InsanıOlustur()
        {
            Console.WriteLine($"{KolSayisi} kol, {BacakSayisi} bacak, sahip bir kadın yaratıyorum.");
        }


        public void YemekYe()
        {
            Console.WriteLine("Yavaş yemek ye.");
        }

        public void Yurume()
        {
            Console.WriteLine("Catwalk yapıyor.");
        }

        public override void KekYap()
        {
            Console.WriteLine("Limonlu kek yapıyorum.");
        }
    }
}

namespace CreateInstanceHuman
{
    public class Erkek : Varlik, IHuman
    {
        public Erkek(string adi, string ırkı, string dogduguYer, string turu) : base(adi, ırkı, dogduguYer, turu)
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
            Console.WriteLine("Ayakta çiş yapabilir.");
        }

        public void InsanıOlustur()
        {
            Console.WriteLine($"{KolSayisi} kol, {BacakSayisi} bacak, sahip bir erkek yaratıyorum.");
        }

        public void Isınlanma()
        {
            Console.WriteLine("Ulaşım seçenekleri upgrade edildi.");
        }

        public void YemekYe()
        {
            Console.WriteLine("Hızlıca ye.");
        }

        public void Yurume()
        {
            Console.WriteLine("Normal ama class bir yürüme.");
        }
    }
}

namespace CreateInstanceHuman.Concrete
{
    public class RastaliKadin : Varlik, IRastali, IHuman
    {
        public RastaliKadin(string adi, string ırkı, string dogduguYer, string turu) : base(adi, ırkı, dogduguYer, turu)
        {
        }

        public bool Bariscil => true;

        public void TenRengi()
        {
            Console.WriteLine("Ten Rengi: Hafif kavruk bir ten.");
            Console.WriteLine();
        }

        public void RenkliGoz()
        {
            Console.WriteLine("Göz Rengi: Mavi göz.");
            Console.WriteLine();
        }

        public void SorfYetenegi()
        {
            Console.WriteLine("Sörf Yeteneği: Doğuştan gelen yetenek. Esneklik yüksek olduğu için adapte olma hızı yüksek.");
            Console.WriteLine();
        }

        public void SuAltindaKalabilme()
        {
            Console.WriteLine("Su Altında Kalabilme: Tercihe göre ayarlanabilir. Min. 3 saat.");
            Console.WriteLine();
        }

        public void InsanıOlustur()
        {
            Console.WriteLine($"{Irkı} ırkına ait, {Adi} adında {Turu} türünde bir kadın varlık oluşturuldu.");
            Console.WriteLine();
        }

        public void YemekYe()
        {
            Console.WriteLine("Default özellik.");
            Console.WriteLine();
        }

        public void CisYap()
        {
            Console.WriteLine("Default özellik.");
            Console.WriteLine();
        }

        public void Yurume()
        {
            Console.WriteLine("Pek tercih edilmeyen eski bir özellik. Son güncelleme ile hatalar düzeltildi.");
            Console.WriteLine();
        }
    }
}

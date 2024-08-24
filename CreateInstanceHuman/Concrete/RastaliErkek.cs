namespace CreateInstanceHuman.Concrete
{
    public class RastaliErkek : Varlik, IRastali, IHuman
    {
        public RastaliErkek(string adi, string ırkı, string dogduguYer, string turu) : base(adi, ırkı, dogduguYer, turu)
        {
        }

        public bool Bariscil => true;

        public void TenRengi()
        {
            Console.WriteLine("Ten Rengi: Daha açık bir ten rengi.");
            Console.WriteLine();
        }

        public void RenkliGoz()
        {
            Console.WriteLine("Göz Rengi: Gri-yeşil arası.");
            Console.WriteLine();
        }

        public void SorfYetenegi()
        {
            Console.WriteLine("Sörf Yeteneği: Doğuştan gelen yetenek. Dayanıklılığı yüksek olduğu için normalden uzun süre board üzerinde kalabilir.");
            Console.WriteLine();
        }

        public void SuAltindaKalabilme()
        {
            Console.WriteLine("Su Altında Kalabilme: Tercihe göre ayarlanabilir. Min. 6 saat.");
            Console.WriteLine();
        }

        public void InsanıOlustur()
        {
            Console.WriteLine($"{Irkı} ırkına ait, {Adi} adında {Turu} türünde bir erkek varlık oluşturuldu.");
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

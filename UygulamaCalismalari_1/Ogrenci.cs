namespace UygulamaCalismalari_1
{
    internal class Ogrenci : Insan
    {
        public string Bolum { get; set; }
        public string OgrenciNo { get; set; }
        public string Sinif { get; set; }

        public virtual void BilgileriAl()
        {
            base.BilgileriAl();
            Console.WriteLine("Lütfen Bölümünüzü Yazınız:");
            Bolum = Console.ReadLine();
            Console.WriteLine("Lütfen Öğrenci Numaranızı Yazınız:");
            OgrenciNo = Console.ReadLine();
            Console.WriteLine("Lütfen Sınıfınızı Yazınız:");
            Sinif = Console.ReadLine();

        }

        public virtual void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine($"Bölüm {Bolum}, OgrenciNo {OgrenciNo}, Sınıf {Sinif}");
        }
    }
}

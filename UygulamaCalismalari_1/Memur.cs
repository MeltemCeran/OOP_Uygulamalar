namespace UygulamaCalismalari_1
{
    internal class Memur : Insan
    {
        public string Birim { get; set; }

        public string SicilNo { get; set; }

        public virtual void BilgileriAl()
        {
            base.BilgileriAl();
            Console.WriteLine("Lütfen Biriminizi Yazınız:");
            Birim = Console.ReadLine();
            Console.WriteLine("Lütfen Sicil Numaranızı Yazınız:");
            SicilNo = Console.ReadLine();

        }

        public virtual void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine($"Birim {Birim}, Soyad {SicilNo}");
        }
    }
}

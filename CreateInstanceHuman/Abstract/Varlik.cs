namespace CreateInstanceHuman
{
    public abstract class Varlik
    {
        private string _adi;

        private string _ırkı;

        private string _dogduguYer; 

        private string _turu;

        public string Turu
        {
            get { return _turu; }
            set { _turu = value; }
        }

        public string DogduguYer
        {
            get { return _dogduguYer; }
            set
            {
                _dogduguYer = value;
            } //türkiye
        }

        public string Irkı
        {
            get { return _ırkı; }
            set { _ırkı = value; }
        }

        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }

        public Varlik(string adi, string ırkı, string dogduguYer, string turu)
        {
            _adi = adi;
            _ırkı = ırkı;
            _dogduguYer = dogduguYer;
            _turu = turu;
        }

        public void VarligiTanıt()
        {
            Console.WriteLine($"{DogduguYer} lokasyonunda; {Adi} adında, {Irkı} ırkına ait bir {Turu} oluşturuluyor. ");
        }


        public void NefesAL()
        {
            Console.WriteLine("Nefes alıyor.");
        }

        public void Uyu()
        {
            Console.WriteLine("Uyuma özelliği eklendi.");
        }

        public void Isınlanma()
        {
            Console.WriteLine("Ulaşım seçenekleri upgrade edildi.");
        }

        public virtual void KekYap()
        {
            Console.WriteLine("Kek yapıyorum.");
        }

    }
}

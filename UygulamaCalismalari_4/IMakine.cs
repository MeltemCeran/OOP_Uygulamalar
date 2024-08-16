namespace UygulamaCalismalari_4
{
    public interface IMakine
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        public void Calis();
        public void Dur();
        public void Bakim();
        public void ParcaDegistir();


    }
}

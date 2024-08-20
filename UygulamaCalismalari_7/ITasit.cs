namespace UygulamaCalismalari_7
{
    public interface ITasit
    {
        
        public string Plaka { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public int UretimYili { get; set; }

        public void Git();

        public void Dur();

        public List<IParca> parcaListesi {  get; set; }
    }
}

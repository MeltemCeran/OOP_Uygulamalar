using CreateInstanceHuman.Concrete;

namespace CreateInstanceHuman
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kadın kadın8 = new Kadın("meltem", "yeni zelandalı", "wellington", "insan");
            //Kadın kadın9 = new Kadın("merve", "adanalı", "çukurova", "insan");

            //Erkek erkek9 = new Erkek("gökhan", "dikmen", "ankara", "insan");
            //Erkek erkek8 = new Erkek("mustafa", "frankfurt", "isviçre", "insanüstü");
            //Erkek erkek7 = new Erkek("alkın", "canada", "oslo", "insan");

            //Console.WriteLine(kadın9.KolSayisi);
            //Console.WriteLine(kadın9.BacakSayisi);


            //Console.WriteLine("Abstract classtan gelenler");
            //kadın9.VarligiTanıt();
            //kadın8.VarligiTanıt();
            //kadın8.Isınlanma();
            //kadın8.Uyu();
            //kadın8.NefesAL();


            //Console.WriteLine("Interfaceten gelenler");
            //kadın9.InsanıOlustur();
            //kadın8.InsanıOlustur();
            //kadın8.CisYap();
            //kadın8.YemekYe();
            //kadın8.Yurume();
            //Console.WriteLine("Meltem yürüdü");

            //kadın9.Yurume();
            //Console.WriteLine("Merve yürüdü");

            //Console.WriteLine("Erkekler yaratılıyor....");
            //Thread.Sleep(2000);

            //Console.WriteLine("Abstract classtan gelenler");
            //erkek8.VarligiTanıt();
            //erkek7.VarligiTanıt();
            //erkek9.VarligiTanıt();
            //erkek9.Isınlanma();
            //erkek9.Uyu();
            //erkek9.NefesAL();


            //Console.WriteLine("Interfaceten gelenler");

            //erkek9.InsanıOlustur();
            //erkek8.InsanıOlustur();
            //erkek7.InsanıOlustur();
            //erkek9.CisYap();
            //erkek9.YemekYe();
            //erkek9.Yurume();


            //Console.WriteLine(new string ('-',50));
            //Console.WriteLine("RASTALI TÜRÜ ÜRETME ALANI");
            //Console.WriteLine(new string('-', 50));

            //RastaliKadin rastali = new RastaliKadin("Seran","Rastali","Rasta adası", "Su-insanı");
            //rastali.VarligiTanıt();

            //Console.WriteLine($"Barışçıl mı? {rastali.Bariscil}");

            //rastali.TenRengi();
            //rastali.RenkliGoz();
            //rastali.SorfYetenegi();
            //rastali.SuAltindaKalabilme();

            //rastali.CisYap();
            //rastali.Isınlanma();
            //rastali.NefesAL();
            //rastali.Yurume();
            //rastali.YemekYe();
            //rastali.Uyu();

            //rastali.InsanıOlustur();

            //Console.WriteLine(new string('-', 50));

            //RastaliErkek rastali1 = new RastaliErkek("Seju", "Rastali", "Rasta adası", "Su-insanı");
            //rastali1.VarligiTanıt();

            //Console.WriteLine($"Barışçıl mı? {rastali1.Bariscil}");

            //rastali1.TenRengi();
            //rastali1.RenkliGoz();
            //rastali1.SorfYetenegi();
            //rastali1.SuAltindaKalabilme();

            //rastali1.CisYap();
            //rastali1.Isınlanma();
            //rastali1.NefesAL();
            //rastali1.Yurume();
            //rastali1.YemekYe();
            //rastali1.Uyu();

            //rastali1.InsanıOlustur();



            Kadın kadın = new Kadın("meltem", "türk","dfgh","sdf");

            kadın.KekYap();

            GencKadin genckadin = new GencKadin("merve", "türk", "yuı", "ert");

            genckadin.KekYap();

            OrtaKadin ortakadin = new OrtaKadin("gizem", "türk", "ıop", "sdf");

            ortakadin.KekYap();
        }
    }
}

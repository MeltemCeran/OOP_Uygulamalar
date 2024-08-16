namespace OOP_Uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Firin Class
            //Console.WriteLine("Hello, World!");

            //Firin firin = new Firin(); //Böyle tanımlarsak fırın sınıfı içerisinde boş bir firin metodu açmalıyım.
            //                           //Ama constructor metotla yazarsam parantez içinde yapıyoruz.
            //firin.Marka = "Bosch";
            //firin.Fiyat = 7500;
            //firin.GarantiVarMi = true;
            //firin.GarantiSuresi = 2;
            //firin.Guc = 1500;
            //firin.MaxDerece = 300;

            //Console.WriteLine($"{firin.Marka} fırın , {firin.Fiyat} TL, {firin.GarantiSuresi} yıl garantili, {firin.MaxDerece} derece max sıcaklık.");

            //firin.Acmak();

            //Firin firin2 = new Firin();

            //firin2.Marka = "Siemens";
            //firin2.Fiyat = 5000;
            //firin2.GarantiVarMi = true;
            //firin2.GarantiSuresi = 2;
            //firin2.Guc = 1200;
            //firin2.MaxDerece = 250;

            //firin2.Acmak();

            //Console.WriteLine("--------");

            //firin.BilgileriYaz();
            //firin2.BilgileriYaz();

            //Firin firin3 = new Firin("Arçelik", 6000, 1300, 3, true, 280);

            //firin3.GarantiUzat(2);
            //firin3.BilgileriYaz();
            #endregion

            #region CalisanlarIT
            //Calisan calisan = new Calisan();

            //calisan.Ad = "Meltem";
            //calisan.Soyad = "Ceran";
            //calisan.Birim = "IT";
            //calisan.SicilNo = "196A";
            //calisan.GorevBaslamaTarihi = DateTime.Now;

            //calisan.BilgileriYaz();


            //Calisan calisan1 = new Calisan("Samet");

            //Console.WriteLine($"{calisan1.Ad}");

            //Calisan calisan2 = new Calisan("Batu", "Özbakır", "IT", "456B", DateTime.Now);

            //calisan2.BilgileriYaz();

            //Calisan calisan3 = new Calisan("Alkın", "Bayrak", "IT", "123C", DateTime.Now);

            //calisan3.BilgileriYaz();

            //Console.WriteLine("---------");

            //calisan.GorevDegistir("SuperIT");
            //calisan2.GorevDegistir("SuperIT");
            //calisan3.GorevDegistir("SuperIT");

            //calisan.BilgileriYaz();
            //calisan2.BilgileriYaz();
            //calisan3.BilgileriYaz();

            //Console.WriteLine("----Burada mağaraya geçiyoruz----");
            //Console.WriteLine();
            #endregion

            #region Örnekler
            //HiddenCave hiddenCave = new HiddenCave();
            //hiddenCave.Guard = 4; //buraya istediğini yaz dene 
            //Console.WriteLine(hiddenCave.Guard);


            //hiddenCave.setStore(15);
            //Console.WriteLine(hiddenCave.getStore());
            //Console.WriteLine("----Burada bişeylere geçiyoruz----");
            //Console.WriteLine();

            //Musteri musteri = new Musteri();
            //musteri.Name = "kek";
            //Console.WriteLine(musteri.Name);


            //Musteri musteri1 = new Musteri();
            //musteri1.SetName("KEK");
            //Console.WriteLine(musteri1.GetName());

            //musteri.TC = "17354678472";
            #endregion


            Enstruman enstruman = new Enstruman();
            enstruman.Ses();

            Piyano piyano = new Piyano();
            piyano.Ses();

            Klavsen klavsen = new Klavsen();
            klavsen.Ses();

            Gitar gitar = new Gitar();
            gitar.Ses();

            

        }
    }
}


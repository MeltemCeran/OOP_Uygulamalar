
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq.Expressions;
using UygulamaCalismalari_7;

namespace UygulamaCalismalari_7
{
    internal class Program
    {
        static List<ITasit> tasitlar = new List<ITasit>();
        static List<IParca> parcalar = new List<IParca>();
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo keychar;
            Karsilama();

            keychar = Console.ReadKey();
            Console.WriteLine();

            while (!(keychar.Key == ConsoleKey.D9 || keychar.Key == ConsoleKey.NumPad9))
            {
                //bunu ifle yapim ya.
                switch (keychar.Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        Tus1(keychar);
                        break;
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        Tus2(keychar);
                        break;
                    case ConsoleKey.D3 or ConsoleKey.NumPad3:
                        Tus3(keychar);
                        break;
                    case ConsoleKey.D4 or ConsoleKey.NumPad4:
                        Tus4();
                        break;
                    case ConsoleKey.D5 or ConsoleKey.NumPad5:
                        Tus5(keychar);
                        break;
                    case ConsoleKey.D6 or ConsoleKey.NumPad6:
                        break;
                    case ConsoleKey.D7 or ConsoleKey.NumPad7:
                        Tus7();
                        break;
                    case ConsoleKey.D8 or ConsoleKey.NumPad8:
                        break;
                   default:
                        break;
                }
                Karsilama();
                keychar = Console.ReadKey();
                Console.WriteLine();
            }
            
        }
       
        static void ParcalarıKaydet()
        {
            StreamWriter Yazici = new StreamWriter("parcalar.txt");
            foreach (var parca in parcalar)
            {
                Yazici.WriteLine($"Tür| {parca.GetType().Name} Ad| {parca.Ad} | Fiyat | {parca.Fiyat} ");
            }
            Yazici.Close();
        }
        static void TasitEkle(ITasit tasit)
        {
            tasitlar.Add(tasit);
        }
        static void TasitGuncelle(ITasit tasit, string plaka, string marka, string model, int yil, List<IParca> parcalar)
        {
            tasit.Plaka = plaka;
            tasit.Marka = marka;
            tasit.Model = model;
            tasit.UretimYili = yil;
            tasit.parcaListesi = parcalar;
        }
        static void TasitSil(ITasit tasit)
        {
            tasitlar.Remove(tasit);
        }
        static void ParcaEkle(IParca parca)
        {
            parcalar.Add(parca);
            ParcalarıKaydet();
        }
        static void ParcaGüncelle(IParca parca, string ad, int fiyat)
        {
            parca.Ad = ad;
            parca.Fiyat = fiyat;
        }
        static void ParcaSil(IParca parca)
        {
            parcalar.Remove(parca);
        }
        static void ParcalariGoster()
        {
            foreach (var parca in parcalar.OrderBy(p => p.GetType().Name))
            {
                Console.WriteLine($"Tür : {parca.GetType().Name}, Ad: {parca.Ad}, Fiyat: {parca.Fiyat}");
            }

        }
        private static void Karsilama()
        {

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Araba eklemek için 1'e");
            Console.WriteLine("Araba güncellemek için 2'ye");
            Console.WriteLine("Araba silmek için 3'e basınız");
            Console.WriteLine("Araba listesini görmek için 4'e basınız.");

            Console.WriteLine("Parça eklemek için 5'e");
            Console.WriteLine("Parça güncellemek için 6'ya");
            Console.WriteLine("Parça  silmek için 7'ye basınız");
            Console.WriteLine("Parça listesini görmek için 8'e basınız.");
            Console.WriteLine("Çıkmak için 9'a basınız.");

            Console.WriteLine(new string('-', 20));
        }
        static void Tus1(ConsoleKeyInfo keychar)
        {
            Console.WriteLine("Araba (1), Kamyon(2), Otobüs(3)");
            keychar = Console.ReadKey();
            Console.WriteLine();
            if (keychar.Key == ConsoleKey.D1 || keychar.Key == ConsoleKey.NumPad1)
            {
                Araba araba = new Araba();
                araba.Marka = "Volvo";
                araba.Model = "XC90";
                araba.Plaka = "48MC222";
                araba.UretimYili = 2024;
                TasitEkle(araba);

            }
            else if (keychar.Key == ConsoleKey.D2 || keychar.Key == ConsoleKey.NumPad2)
            {
                Kamyon kamyon = new Kamyon();
                kamyon.Marka = "BMC";
                kamyon.Model = "Uhh";
                kamyon.Plaka = "selam123";
                kamyon.UretimYili = 2020;

                TasitEkle(kamyon);
            }
            else if (keychar.Key == ConsoleKey.D3 || keychar.Key == ConsoleKey.NumPad3)
            {
                Otobüs otobüs = new Otobüs();
                otobüs.Marka = "Mercedes";
                otobüs.Model = "kamilkoç";
                otobüs.Plaka = "as456";
                otobüs.UretimYili = 2021;
                TasitEkle(otobüs);
            }
        }
        static void Tus2(ConsoleKeyInfo keychar)
        {
            Console.WriteLine("Bunu bilemedim.");
        }
        static void Tus3(ConsoleKeyInfo keychar)
        {
            Console.WriteLine("Araba (1), Kamyon(2), Otobüs(3)");
            keychar = Console.ReadKey();
            Console.WriteLine();
            if (keychar.Key == ConsoleKey.D1 || keychar.Key == ConsoleKey.NumPad1)
            {

            }
            else if (keychar.Key == ConsoleKey.D2 || keychar.Key == ConsoleKey.NumPad2)
            {
                tasitlar.Remove(tasitlar[1]);
            }
            else if (keychar.Key == ConsoleKey.D3 || keychar.Key == ConsoleKey.NumPad3)
            {
                tasitlar.Remove(tasitlar[2]);
            }
        }
        static void Tus4()
        {
            foreach (ITasit t in tasitlar)
            {
                Console.WriteLine(t);
            }
        }
        static void Tus5(ConsoleKeyInfo keychar)
        {
            bool aynıİsimdeParcaVarMi = false;
            int tus;
            IParca parca;
            List<Type> turler = new List<Type>()
            {
                typeof(Buji),
                typeof(Balata),
                typeof(Disk),
                typeof(Bobin),
                typeof(Suspansiyon),
            };

            Console.WriteLine("Parça ekleme bölümü.");
            Console.WriteLine("Buji (0), Balata(1), Disk(2), Bobin(3), Süspansiyon(4)");
            tus = Convert.ToInt32(Console.ReadLine());

            parca = (IParca)Activator.CreateInstance(turler[tus]);
            do
            {
                aynıİsimdeParcaVarMi = false;

                Console.WriteLine("Lütfen adını giriniz:");
                parca.Ad = Console.ReadLine();

                foreach (var prc in parcalar)
                {
                    if (parca.Ad == prc.Ad)
                    {
                        Console.WriteLine("Yazdığınız isme ait parça mevcuttur. Tekrar giriniz:");
                        aynıİsimdeParcaVarMi = true;
                        break;
                    }
                }
            } while (aynıİsimdeParcaVarMi);

            Console.WriteLine("Lütfen fiyatını giriniz:");
            parca.Fiyat = Convert.ToInt32(Console.ReadLine());

            ParcaEkle(parca);
            Console.WriteLine();
            ParcalariGoster();

            #region IF else ile yapımı
            //Activator kullanımı ile hızlıca yapılışı. Aşağıdaki if ile yapımı.

            //if (keychar.Key == ConsoleKey.D1 || keychar.Key == ConsoleKey.NumPad1)
            //{
            //    Console.WriteLine("Lütfen adını giriniz:");
            //    Buji buji = new Buji();
            //    buji.Ad = Console.ReadLine();
            //    Console.WriteLine("Lütfen fiyatını giriniz:");
            //    buji.Fiyat = Convert.ToInt32(Console.ReadLine());

            //    ParcaEkle(parca);
            //}
            //else if (keychar.Key == ConsoleKey.D2 || keychar.Key == ConsoleKey.NumPad2)
            //{
            //    Console.WriteLine("Lütfen adını giriniz:");
            //    Balata balata = new Balata();
            //    balata.Ad = Console.ReadLine();
            //    Console.WriteLine("Lütfen fiyatını giriniz:");
            //    balata.Fiyat = Convert.ToInt32(Console.ReadLine());

            //    ParcaEkle(balata);
            //}
            //else if (keychar.Key == ConsoleKey.D3 || keychar.Key == ConsoleKey.NumPad3)
            //{
            //    Console.WriteLine("Lütfen adını giriniz:");
            //    Disk disk = new Disk();
            //    disk.Ad = Console.ReadLine();
            //    Console.WriteLine("Lütfen fiyatını giriniz:");
            //    disk.Fiyat = Convert.ToInt32(Console.ReadLine());

            //    ParcaEkle(disk);
            //}
            //else if (keychar.Key == ConsoleKey.D4 || keychar.Key == ConsoleKey.NumPad4)
            //{
            //    Console.WriteLine("Lütfen adını giriniz:");
            //    Bobin bobin = new Bobin();
            //    bobin.Ad = Console.ReadLine();
            //    Console.WriteLine("Lütfen fiyatını giriniz:");
            //    bobin.Fiyat = Convert.ToInt32(Console.ReadLine());

            //    ParcaEkle(bobin);
            //}
            //else if (keychar.Key == ConsoleKey.D5 || keychar.Key == ConsoleKey.NumPad5)
            //{
            //    Console.WriteLine("Lütfen adını giriniz:");
            //    Suspansiyon süspansiyon = new Suspansiyon();
            //    süspansiyon.Ad = Console.ReadLine();
            //    Console.WriteLine("Lütfen fiyatını giriniz:");
            //    süspansiyon.Fiyat = Convert.ToInt32(Console.ReadLine());

            //    ParcaEkle(süspansiyon);
            //}
            #endregion

        }
        static void Tus6()
        {
            IParca guncellenecekParca = null;
            bool kendisiDısındaIsımVarMi = false;
            string parcaAdi;
            string yazilanIsim;
            int guncelFiyat;

            Console.WriteLine("Parça silme ekranı.");
            Console.WriteLine("Güncellemek istediğiniz parçanın adını yazınız.");
            parcaAdi = Console.ReadLine();

            foreach (var prc in parcalar)
            {
                if (parcaAdi == prc.Ad)
                {
                    guncellenecekParca = prc;
                    break;
                }
            }

            if (guncellenecekParca != null)
            {
                Console.WriteLine("Güncel parça adını yazınız");
                yazilanIsim = Console.ReadLine();

                foreach (var prc in parcalar)
                {
                    if (guncellenecekParca != prc && yazilanIsim == prc.Ad)
                    {
                        kendisiDısındaIsımVarMi = true;
                        break;
                    }
                }


                if (!kendisiDısındaIsımVarMi)
                {
                    Console.WriteLine("Güncel fiyatı yazınız");
                    guncelFiyat = Convert.ToInt32(Console.ReadLine());

                    ParcaGüncelle(guncellenecekParca, yazilanIsim, guncelFiyat);
                }
                else
                {
                    Console.WriteLine("Yazdığınız isme ait parça bulunamamıştır.");
                }
            }
            ParcalariGoster();
        }
        static void Tus7()
        {
            IParca silinecekParca = null;
            bool aynıİsimdeParcaVarMi = false;
            string parcaAdi;

            Console.WriteLine("Parça silme ekranı.");
            Console.WriteLine("Silmek istediğiniz parçanın adını yazınız.");

            parcaAdi = Console.ReadLine();

            foreach (var prc in parcalar)
            {
                if (parcaAdi == prc.Ad)
                {
                    silinecekParca = prc;
                    aynıİsimdeParcaVarMi = true;
                    break;
                }
            }
            if (silinecekParca != null)
            {
                ParcaSil(silinecekParca);
            }
            else
            {
                Console.WriteLine("Yazdığınız isme ait parça bulunamamıştır.");
            }

            ParcalariGoster();
        }
        static void Tus8()
        {
            ParcalariGoster();
        }

     
    }
}


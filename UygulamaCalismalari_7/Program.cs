
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using UygulamaCalismalari_7;

namespace UygulamaCalismalari_7
{
    internal class Program
    {
        static List<ITasit> tasitlar = new List<ITasit>();
        static List<IParca> parcalar = new List<IParca>();
        
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
                TasitSil(tasit);
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
            Console.WriteLine("Buji (1), Balata(2), Disk(3), Bobin(4), Süspansiyon(5)");
            keychar = Console.ReadKey();
            Console.WriteLine();
            if (keychar.Key == ConsoleKey.D1 || keychar.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("Lütfen adını giriniz:");
                Buji buji = new Buji();
                buji.Ad = Console.ReadLine();
                Console.WriteLine("Lütfen fiyatını giriniz:");
                buji.Fiyat = Convert.ToInt32(Console.ReadLine());

                ParcaEkle(buji);
            }
            else if (keychar.Key == ConsoleKey.D2 || keychar.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("Lütfen adını giriniz:");
                Balata balata = new Balata();
                balata.Ad = Console.ReadLine();
                Console.WriteLine("Lütfen fiyatını giriniz:");
                balata.Fiyat = Convert.ToInt32(Console.ReadLine());

                ParcaEkle(balata);
            }
            else if (keychar.Key == ConsoleKey.D3 || keychar.Key == ConsoleKey.NumPad3)
            {
                Console.WriteLine("Lütfen adını giriniz:");
                Disk disk = new Disk();
                disk.Ad = Console.ReadLine();
                Console.WriteLine("Lütfen fiyatını giriniz:");
                disk.Fiyat = Convert.ToInt32(Console.ReadLine());

                ParcaEkle(disk);
            }
            else if (keychar.Key == ConsoleKey.D4 || keychar.Key == ConsoleKey.NumPad4)
            {
                Console.WriteLine("Lütfen adını giriniz:");
                Bobin bobin = new Bobin();
                bobin.Ad = Console.ReadLine();
                Console.WriteLine("Lütfen fiyatını giriniz:");
                bobin.Fiyat = Convert.ToInt32(Console.ReadLine());

                ParcaEkle(bobin);
            }
            else if (keychar.Key == ConsoleKey.D5 || keychar.Key == ConsoleKey.NumPad5)
            {
                Console.WriteLine("Lütfen adını giriniz:");
                Suspansiyon süspansiyon = new Suspansiyon();
                süspansiyon.Ad = Console.ReadLine();
                Console.WriteLine("Lütfen fiyatını giriniz:");
                süspansiyon.Fiyat = Convert.ToInt32(Console.ReadLine());

                ParcaEkle(süspansiyon);
            }
        }
        static void Tus6()
        {
            Console.WriteLine("Bu da yok :(");
        }

      


        static void Main(string[] args)
        {

            Console.WriteLine("Araba Uygulamasına Hoşgeldiniz!");
            Console.WriteLine(new string('-',20));
            ConsoleKeyInfo keychar;

            while (true)
            {
                Console.WriteLine("Araba eklemek için 1'e");
                Console.WriteLine("Araba güncellemek için 2'ye");
                Console.WriteLine("Araba silmek için 3'e basınız");
                Console.WriteLine("Araba listesini görmek için 4'e basınız.");

                Console.WriteLine("Parça eklemek için 5'e");
                Console.WriteLine("Parça güncellemek için 6'ya");
                Console.WriteLine("Parça  silmek için 7'ye basınız");
                Console.WriteLine("Parça listesini görmek için 8'e basınız.");
                Console.WriteLine("Çıkmak için 9'a basınız.");

                keychar = Console.ReadKey();
                Console.WriteLine();

                //bunu ifle yapim ya.
                switch (keychar.Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        Tus1(keychar);
                        continue;
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        Tus2(keychar);
                        continue;
                    case ConsoleKey.D3 or ConsoleKey.NumPad3:
                        Tus3(keychar);
                        continue;
                    case ConsoleKey.D4 or ConsoleKey.NumPad4:
                        Tus4();
                        continue;
                    case ConsoleKey.D5 or ConsoleKey.NumPad5:
                        Tus5(keychar);
                        continue;
                    case ConsoleKey.D6 or ConsoleKey.NumPad6:
                        continue;
                    case ConsoleKey.D7 or ConsoleKey.NumPad7:
                        continue;
                    case ConsoleKey.D8 or ConsoleKey.NumPad8:
                        continue;
                    case ConsoleKey.D9 or ConsoleKey.NumPad9:
                        break;
                }
                foreach (ITasit tasit in tasitlar)
                {
                    Console.WriteLine($"{tasit.Marka} , {tasit.Model}, {tasit.Plaka}, {tasit.UretimYili}");
                }
            }
            
        }

        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulamalar
{
    internal class Calisan
    {
        public Calisan()
        {
            
        }
        public Calisan(string ad)
        {
            Ad = ad;
        }

        public Calisan(string ad, string soyad, string birimNo, string sicilNo, DateTime goreveBaslamaTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            Birim = birimNo;
            GorevBaslamaTarihi = goreveBaslamaTarihi;
            SicilNo = sicilNo;

        }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Birim { get; set; }

        public DateTime GorevBaslamaTarihi { get; set; }
        public string SicilNo { get; set; } 

        public void BilgileriYaz()
        {
            Console.WriteLine($"{Ad}, {Soyad}, {Birim}, {SicilNo}, {GorevBaslamaTarihi}");
        }

        public void GorevDegistir(string YeniBirim)
        {
            Birim = YeniBirim;
        }

    }
}

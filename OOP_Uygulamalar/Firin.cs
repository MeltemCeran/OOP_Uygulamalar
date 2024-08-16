using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulamalar
{
    internal class Firin
    {
        
        //ctor yapıp tab tab => constructor metot.
        public Firin()
        {

        }

        public Firin(string marka, decimal fiyat, double guc, int garantiSuresi, bool garantiVarMi, int derece)
        {
            Marka = marka;
            Fiyat = fiyat;
            Guc = guc;
            GarantiSuresi = garantiSuresi;
            GarantiVarMi = garantiVarMi;
            MaxDerece = derece;
           
        }

        public string Marka { get; set; }

        public decimal Fiyat { get; set; }

        public double Guc { get; set; }

        public int GarantiSuresi { get; set; }

        public bool GarantiVarMi { get; set; }

        public int MaxDerece { get; set; }
        
        public void Acmak()
        {
            Console.WriteLine($"Markası {Marka} olan fırın açıldı.");
        }
        public void Kapatmak()
        {

        }
        public void Isın()
        {

        }
        public void GarantiUzat(int sure)
        {
            GarantiSuresi += sure;
        }
        public void BilgileriYaz()
        {
            Console.WriteLine($" {Marka} fırın , {Fiyat} TL, {GarantiSuresi} yıl ganratili, {MaxDerece} derece max sıcaklık.");
        }
    }
}

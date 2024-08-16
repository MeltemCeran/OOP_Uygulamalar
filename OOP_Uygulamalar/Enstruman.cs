using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulamalar
{
    internal class Enstruman
    {
        public string Marka { get; set; }

        public double Fiyat { get; set; }

        public bool Durum { get; set; }

        protected string Renk { get; set; } //private yapsaydık ne piyanoda ne de klavsende kullanılamaz.


        public void Ses()
        {
            Console.WriteLine("Sesi geliyor.");
        }
    }
}

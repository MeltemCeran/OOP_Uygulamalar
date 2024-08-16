using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaCalismalari_3
{
    internal abstract class Hayvan
    {
        public string Ad { get; set; }

        public string Cins { get; set; }

        public string YasadigiYer { get; set; }

        public string Cinsiyet { get; set; }

        public abstract void Ses();

        public void BilgileriYaz()
        {
            Console.WriteLine($"Adı : {Ad}, Cins {Cins}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulamalar
{
    internal class Piyano : Enstruman
    {
        public void Ses()
        {
            Console.WriteLine("Piyanonun sesi geliyor.");
        }

        protected List<string> Pedallar { get; set; } // sadece bu sınıfın içinde tanımladığım ata sınıf tarafından görülmez ama alt sınıfı görür.

        public Piyano()
        {
            Console.WriteLine(Marka);
        }
    }
}

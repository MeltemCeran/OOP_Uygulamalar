using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaCalismalari_1
{
    internal class Insan
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string TcNo { get; set; }

        public virtual void BilgileriAl()
        {
            Console.WriteLine("Lütfen Adınızı Yazınız:");
            Ad = Console.ReadLine();
            Console.WriteLine("Lütfen Soyadınızı Yazınız:");
            Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen Doğum Tarihinizi Yazınız:");
            DogumTarihi = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Lütfen Tc Kimlik Numaranızı Yazınız:");
            TcNo = Console.ReadLine();

        }

        public virtual void BilgileriGoster()
        {
            Console.WriteLine($"Ad {Ad}, Soyad {Soyad}, Doğum Tarihi {DogumTarihi}, Tc Kimlik No {TcNo}");

        }
    }
}

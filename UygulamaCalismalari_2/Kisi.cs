using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaCalismalari_2
{
    internal class Kisi
    {
        public Kisi()
        {
            Console.WriteLine("Kişi oluşturuluyor.");
        }

        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set
            {
                if (value.GetType() == typeof(string))
                {
                    _ad = value;
                }
                else
                    throw new Exception("Geçersiz giriş");

            }
        }

        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new Exception("Geçersiz değer");
                    }
                    _ad = value;
                }


            }
        }

        private double _boy;

        public double Boy
        {
            get { return _boy; }
            set
            {
                if (value <= 0.30 && value >= 2.55)
                {
                    _boy = value;
                }
                else
                    throw new Exception("Geçersiz değer");
                
            }
        }

        private string _cinsiyet;

        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set
            {

                if (value.ToUpper() == "ERKEK" && value.ToUpper() == "KADIN")
                {
                    _cinsiyet = value;
                }
                else
                {
                    Console.WriteLine("Tekrar deneyiniz");
                    value = Console.ReadLine();
                }

            }
        }
        
        public Kisi(string Ad, string Soyad, double Boy, string Cinsiyet)
        {
            _ad = Ad;
            _soyad = Soyad;
            _boy = Boy;
            _cinsiyet = Cinsiyet;
        }

       
    }
}

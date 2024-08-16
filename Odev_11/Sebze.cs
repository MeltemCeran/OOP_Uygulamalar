using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_11
{
    internal class Sebze
    {
        public string SebzeAdi { get; set; }
        protected string Birimi { get; set; }

        private decimal _fiyat;

        public decimal Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value > 13)
                {
                    _fiyat = value;
                }
                else
                {
                    _fiyat = (decimal)9.9;
                }
            }
        }


        protected decimal FiyatOlustur(decimal gelenFiyat) //bundan emin değilim??
        {
            return _fiyat;
        }

        public decimal FiyatBildir(decimal fiyat)
        {
            return _fiyat;
        }

        public string BirimiGetir()
        {
            return _birimi;
        }
    }
}

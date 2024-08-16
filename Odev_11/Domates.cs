using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_11
{
    internal class Domates : Sebze
    {
        private string _sebzeAdi;

        private string _birimi;

        public Domates(string SebzeAdi, string Birimi)
        {
            _sebzeAdi = SebzeAdi;
            _birimi = Birimi;
        }
    }
}

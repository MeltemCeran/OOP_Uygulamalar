using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulamalar
{
    internal class HiddenCave
    {
        private int _store;
        private int _box;

        public int Guard
        {
            get { return _box; } //değer ataması yaptığında set, değer atamasına eriştiğinde get.
            set
            {
                if (value <= 0)
                    _box = 0;
                else if (value <= 5)
                    _box = value;
                else
                    _box = 5;
            }
        }

        public void setStore(int value)
        {
            if (value < 10)
                _store = -5;
            else if (value <= 20)
                _store = value;
            else
                _store = 100;

            switch (value)
            {
                case <= 10:
                    _store = -5;
                    break;
                case <= 20:
                    _store = value;
                    break;
                default:
                    _store = 100;
                    break;
            }
        }
        public int getStore()
        {
            return _store;
        }
    }
}

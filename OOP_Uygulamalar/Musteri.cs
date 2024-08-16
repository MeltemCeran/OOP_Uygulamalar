using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulamalar
{
    internal class Musteri
    {
        private string _name;

        private string _tc;


        public string TC
        {
            get 
            {
                return _tc;

            }
            set
            {

                if (value.Length!=11)
                {
                    Console.WriteLine("11 basamaklı olmalıdır.");
                }
                else if (value[0]==0)
                {
                    Console.WriteLine("O ile başlamamalıdır.");
                }
                else
                {
                    int grupA=0, grupB=0, toplam=0;
                    for (int i = 0; i <= value.Length-2; i++)
                    {
                        if (i % 2 == 0)
                            grupA += Convert.ToInt32(value[i].ToString());

                        else if (i % 2 == 1 && i < 9)
                            grupB += Convert.ToInt32(value[i].ToString());

                        toplam += Convert.ToInt32(value[i].ToString());
                    }

                    var x = (7 * grupA) - grupB;
                    if(x % 10 != Convert.ToInt32(value[value.Length-2].ToString()))
                    {
                        Console.WriteLine("Geçersiz TC no 10 basamak algoritmaya göre olmadı.");
                    }
                    else if (toplam %10 != Convert.ToInt32(value[value.Length - 1].ToString()))
                    {
                        Console.WriteLine("Geçersiz TC no 11 basamak algoritmaya göre olmadı.");
                    }
                    else
                    {
                        _tc = value;
                        Console.WriteLine("Geçerli TC girdiniz.");
                    }
                }

               

            }
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (char.IsLetter(value[0]))
                {
                    _name = value;
                }
                else
                {
                    _name = "Geçersiz giriş";  
                    
                }

                //switch (char.IsLetter(value[0]))
                //{
                //    case true:
                //        _name = value;
                //        break;

                //    case false:
                //        Console.WriteLine("Geçersiz giriş");
                //        break;
                //}
            }
        }

        public string GetName() 
        { 
            return _name; 
        }
       
        public void SetName(string name)
        {
            if (char.IsLetter(name[0]))
            {
                _name = name;
            }
            else
            {
                _name = "Geçersiz giriş";

            }
        }
    }
}

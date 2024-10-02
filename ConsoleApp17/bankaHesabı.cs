using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    internal class bankaHesabı
    {
        public int bankaHesab { get; set; }
        public string kullaniciAdi {  get; set; }
        public string kullaniciSoyadi { get; set; }

        internal void ParaCek(int cekilecekTutar)
        {
            bankaHesab -= cekilecekTutar;
        }

        internal void Parayatir(int yatirilacakTutar)
        {
            bankaHesab += yatirilacakTutar;
        }
    }
}

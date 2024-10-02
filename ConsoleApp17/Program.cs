using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random rand = new Random();
                Console.WriteLine("akbank");

                bankaHesabı hesap = new bankaHesabı
                {
                    bankaHesab = rand.Next(0, 100000),
                    kullaniciAdi = "ahmet",
                    kullaniciSoyadi = "dağdelen"
                };
                Console.WriteLine($"{hesap.kullaniciAdi} {hesap.kullaniciSoyadi} {hesap.bankaHesab}");

                Console.WriteLine(" yapacağınız işlemi seçin \n 1: para çekme. \n 2: para yatırma. \n 3: kalan bakiyeyi göster");

                int secim = Convert.ToInt32( Console.ReadLine() );
                if (secim == 1)
                {
                    Console.WriteLine("çekmek istediğiniz tutarı girin");
                    var cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                    hesap.ParaCek(cekilecekTutar);
                }
                else if (secim == 2)
                {
                    Console.WriteLine("yatırmak istediğiniz tutarı girin");
                    var yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                    hesap.Parayatir(yatirilacakTutar);

                }
                else if (secim == 3)
                {
                    Console.WriteLine($"kalan bakiye: {hesap.bankaHesab}");
                }
                else { Console.WriteLine("geçersiz seçim"); }


                Console.WriteLine($"kalan bakiye: {hesap.bankaHesab}");
            }
        }
    }
}
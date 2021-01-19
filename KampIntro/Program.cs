using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // Do Not Repeat Yourself - Kendini tekrarlama
           string kategoriEtiketi = "Kategoriler:";
           int ogrenciSayisi = 32000;
           double faizOrani = 1.45;
           bool sistemeGirisYapmisMi = true;
            double dolarBugun = 7.15;
            double dolarDun = 7.25;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

           Console.WriteLine(kategoriEtiketi);
        }
    }
}

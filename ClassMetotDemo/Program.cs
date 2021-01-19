using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriProfili musteri1 = new MusteriProfili();

            musteri1.Adi = "Emir";
            musteri1.Soyadi = "Arslan";
            musteri1.TckNo = "11111111111";
            musteri1.KayitYili = "1991";

            MusteriProfili musteri2 = new MusteriProfili();

            musteri2.Adi = "Funda Gizem";
            musteri2.Soyadi = "Nalbant Arslan";
            musteri2.TckNo = "00000000000";
            musteri2.KayitYili = "1993";

            MusteriProfili[] musteriler = new MusteriProfili[] {
                musteri1,
                musteri2
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("----------------------------------------------------");

            musteriManager.Listele(musteriler);

            Console.WriteLine("----------------------------------------------------");

            musteriManager.Sil(musteri1);

        }
    }
}

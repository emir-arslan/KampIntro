using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Ekle(MusteriProfili Musteri)
        {
            Console.WriteLine("Tebrikler.Müşteri Eklendi : " + Musteri.Adi + " " + Musteri.Soyadi);
        }

        public void Sil(MusteriProfili Musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi : " + Musteri.Adi + " " + Musteri.Soyadi);
        }

        public void Listele(MusteriProfili[] musteriler)
        {
            foreach (MusteriProfili musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı :" + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı :" + musteri.Soyadi);
                Console.WriteLine("TC Kimlik No :" + musteri.TckNo);
                Console.WriteLine("Banka Kayıt Yılı :" + musteri.KayitYili);
                Console.WriteLine("----------------");
            }
        }
    }
}

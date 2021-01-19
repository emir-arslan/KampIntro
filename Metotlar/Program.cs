using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };


            //type-safe = tip güvenli var-->Urun
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------------Metotlar---------------");

            //instance - Örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Deveci", 12, 10);
            sepetManager.Ekle2("Elma", "Amasya Elması", 12, 15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12 , 9);

        }
    }
}


//Dont repeat yourself = DRY = Clean Code
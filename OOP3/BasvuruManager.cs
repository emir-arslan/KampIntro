using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection 
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //
            //Hangi kredi tipini gönderirsek onun hesaplası çalışır.Kredi türü bağımsız hale getirdik.
            krediManager.Hesapla();
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //IkrediManager türünde Liste ver ki hepsinin bilgilendirmesini sana vereyim.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

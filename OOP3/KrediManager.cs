using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    //interfaceler birbirinin alternatifi olan fakat farklı istekleri kodları farklı olan durumların referanslarını tutmaları için kullanılır.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}

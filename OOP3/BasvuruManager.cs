using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme ve başka şeyler yapılır

            //KonutKrediManager konutKrediManager = new KonutKrediManager(); //dersek tüm başvurular konut kredisi üzerinden yapılır
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

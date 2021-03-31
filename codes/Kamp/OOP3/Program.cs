using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager emlakKrediManager = new EmlakKrediManager();
            emlakKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager);
            basvuruManager.BasvuruYap(emlakKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager> { konutKrediManager, emlakKrediManager};
            basvuruManager.KrediBilgilendirmeYap(krediler);
        }
    }
}

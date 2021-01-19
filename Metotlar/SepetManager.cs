using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - Pascal case - ilk harf büyük
        //Method çift parantez ile gösterilir (syntax'ı öyle)
        public void Ekle(Urun urun)
        {
             Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        //Urun class ı kullanmadan da yapılabilir. Ama o zaman Urun'e eklenen yeni özellikleri her yerde ayrı ayrı düzeltmek gerekecek.
        //O yüzden class yapmakta fayda var. Buna encapsulation deniyor.


        //Bu class yapısı iyi bir örnek değil mesela
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete eklendi2 : " + urunAdi + "  " + aciklama + "  " + fiyat);

        }
    }
}

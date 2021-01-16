using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dont repeat yourself - DRY - Clean Code - Best Practice
            //Metotlar: eger tekrar tekrar kullanılacak bir kod blogu varsa metotlar kullanılabilir
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 200;

            Urun[] urunler = new Urun[] {urun1,urun2};

            //type-safe - her değişkene tip ataması yapılmalı
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("--------------------------");

            }

            Console.WriteLine("---------------Metotlar-------------------");

            //instance yapıyoruz
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Sarı Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15);
            sepetManager.Ekle2("Karpuz", "Kırmızı karpuz", 30);
        }
    }
}

using System;

namespace Urunler
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Airpod";
            urun1.UrunFiyati = 2000;
            urun1.KalanUrunAdedi = 20;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Macbook";
            urun2.UrunFiyati = 8000;
            urun2.KalanUrunAdedi = 10;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Ipad";
            urun3.UrunFiyati = 6000;
            urun3.KalanUrunAdedi = 15;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("For Döngüsü\n");
            Console.WriteLine("Ürün Adı : Ürün Fiyatı : Kalan Adet\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunFiyati + " : " + urunler[i].KalanUrunAdedi);
            }

            Console.WriteLine("\nForeach Döngüsü\n");
            Console.WriteLine("Ürün Adı : Ürün Fiyatı : Kalan Adet\n");
              
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati + " : " + urun.KalanUrunAdedi);
            }
            
            Console.WriteLine("\nWhile Döngüsü\n");
            Console.WriteLine("Ürün Adı : Ürün Fiyatı : Kalan Adet\n");
            int y = 0;
            while (y < 3)
            {
                Console.WriteLine(urunler[y].UrunAdi + " : " + urunler[y].UrunFiyati + " : " + urunler[y].KalanUrunAdedi);
                y++;
            }
        }
    }

    class Urun //object definition
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public int KalanUrunAdedi { get; set; }

    }
}

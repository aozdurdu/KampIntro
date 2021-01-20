using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Adi = "İsmet";
            musteri1.Soyadi = "Kılıç";
            musteri1.Yasi = 56;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Adi = "Fatih";
            musteri2.Soyadi = "Kılıç";
            musteri2.Yasi = 38;

            
            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            //foreach (Musteri musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.ID);
            //    Console.WriteLine(musteri.Adi);
            //    Console.WriteLine(musteri.Soyadi);
            //    Console.WriteLine(musteri.Yasi);
            //    Console.WriteLine("--------------------------");
            //}

            Console.WriteLine("---------------Operasyonlar-------------------");

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------------Ekle-------------------");

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("---------------Listele-------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            Console.WriteLine("---------------Silme-------------------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
        }
    }
}

using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //kategoriEtiketi bir alias'dır
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            Console.WriteLine("if-else bitti");
            
            int girilenSayi = 0;

            if (girilenSayi > 0)
            {
                Console.WriteLine("Pozitif Sayı Girildi");
            }
            else if (girilenSayi < 0)
            {
                Console.WriteLine("Negatif Sayı Girildi");
            }
            else
            {
                Console.WriteLine("Sıfır Girildi");
            }

            Console.WriteLine("if-else bitti");


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine("if-else bitti");

            
            switch (sistemeGirisYapmisMi)
            {
                case true:
                    Console.WriteLine("Kullanıcı ayarları butonu");
                    break;

                default:
                    Console.WriteLine("Giriş yap butonu");
                    break;
            }
            
            int gun = (int)DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1:
                    Console.Write("Bugün Pazartesi");
                    break;
                case 2:
                    Console.Write("Bugün Salı");
                    break;
                case 3:
                    Console.Write("Bugün Çarşamba");
                    break;
                case 4:
                    Console.Write("Bugün Perşembe");
                    break;
                case 5:
                    Console.Write("Bugün Cuma");
                    break;
                case 6:
                    Console.Write("Bugün Cumartesi");
                    break;
                case 7:
                    Console.Write("Bugün Pazar");
                    break;
            }
            Console.Write("\n");
            string hangiGun = "Cumartesi";
            switch (hangiGun)
            {
                case "Pazartesi":
                    Console.Write("Hafta içi");
                    break;
                case "Salı":
                    Console.Write("Hafta içi");
                    break;
                case "Çarşamba":
                    Console.Write("Hafta içi");
                    break;
                case "Perşembe":
                    Console.Write("Hafta içi");
                    break;
                case "Cuma":
                    Console.Write("Hafta içi");
                    break;
                case "Cumartesi":
                    Console.Write("Hafta sonu");
                    break;
                case "Pazar":
                    Console.Write("Hafta sonu");
                    break;
                default:
                    Console.Write("Hatalı giriş");
                    break;
            }
            Console.Write("\nKaçıncı ayda olduğunuzu girin:");
            int ay = Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Sonbahar mevsimi");
                    break;
                default:
                    Console.Write("Ay bilgisini yanlış girdiniz.");
                    break;
            }
        }
    }
}

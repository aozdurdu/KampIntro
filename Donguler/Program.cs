using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            
            //array = dizi. pyton'da bu list diye geçiyor

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(i+"-"+kurslar[i]+"\n");
            }

            Console.WriteLine("For bitti\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer\n");
            
            int y = 0;
            while (y < kurslar.Length)
            {
                Console.WriteLine(y + "-" + kurslar[y] + "\n");
                y++;
            }
            Console.WriteLine("while bitti\n");

            int sayi = 0, toplam = 0; // değişkenlerin başlangıç değeri 0 olarak ayarlanıyor. 
            while (sayi % 2 == 0)  // koşulda sayi değişkeninin çift olup olmadığına bakılıyor.  
            {
                toplam = toplam + sayi; //döngü içerisinde sayi değişkeninin değeri toplama ekleniyor.  
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToInt16(Console.ReadLine());  // Girilen değer sayi değişkenine atanıyor.  
            }
            Console.WriteLine("Girilen Çift Sayıların Toplamı = " + toplam); // Toplam sonuç yazdırılıyor.
            Console.WriteLine("\nYeni While\n");

            int z = 1;
            int t = 0;
            int sekizebolunen = 0;

            while (z < 100)
            {
                if (z%10==0)
                {
                    sekizebolunen += z;
                    t++;
                }
                z++;
            }
            Console.WriteLine("0'dan 100'e kadar 8'e bölünen kaç sayı var? = " + t + "\n");
            Console.WriteLine("Bu Sayıların Toplamı = " + sekizebolunen);

            int a = 2;
            int b = 0;
            int c = 1;
            int d = 1;

            Console.WriteLine(b + "\n" + c);
            while (a < 10)
            {

                d = b + c;

                Console.WriteLine(d);
                b = c;
                c = d;
                        
                a++;
            }
        }
    }
}

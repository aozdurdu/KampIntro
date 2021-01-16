using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //array, class, interface = referans tip
            //int, decimal, float, double, bool = değer tip
            //stack= değerler
            //heap= referans : array'deki new ile heap'te adres oluşturur ve kare parantez artık heap'te tutulur. Yani referanst tip adres tutar. C'de bunun adı Pointer.

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? 30

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] {10, 20, 30};
            int[] sayilar2 = new int[] {100, 200, 300};

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]?? 999

            Console.WriteLine(sayilar1[0]);
        }
    }
}

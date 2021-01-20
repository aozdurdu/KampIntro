using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int x, int sayi1=2, int sayi2=1)
          
        {
            int toplam = x+ sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}

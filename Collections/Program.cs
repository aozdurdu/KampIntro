using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Engin", "Murat", "Kerem", "Halil"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //names[4] = "İlker";
            //Console.WriteLine(names[4]);

            List<string> names2 = new List<string> {"Engin", "Murat", "Kerem", "Halil"};
            names2.Add("İlker");
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Yunus");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[5]);
            Console.WriteLine(names2[0]);

            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }

            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine(numbers[y]);
            }
        }
    }
}

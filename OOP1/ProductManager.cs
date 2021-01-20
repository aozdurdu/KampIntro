using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //void: like order. You cannaot use the result in another method.
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " added.");
        
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");

        }

        //public int Addition(int number1, int number2)
        //{
        //    return number1 + number2;
        //}

        //public void Addition2(int number1, int number2)
        //{
        //    Console.WriteLine(number1 + number2);
        }
    }
}

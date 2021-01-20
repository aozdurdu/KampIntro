using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Product is filled manually: Style1
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // Product is filled by hand: Style2
            Product product2 = new Product {ID=2, CategoryID=5, ProductName="Pen", UnitsInStock=5, UnitPrice=35 };

            //Normally in real systems it should be done via database

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            
            
            
            
            //productManager.Addition2(3, 6);
            
            //int additionResult = productManager.Addition(3, 6);
            //Console.WriteLine(additionResult*2);

            //int, double, bool...Value Types
            //array, class, abstarct class, interface...Reference Type
            //ref & out keywords for to use value types as rerefence type

        }
    }
}

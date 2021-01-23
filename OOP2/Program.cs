using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Jack";
            customer1.LastName = "Jackson";
            customer1.TcNo = "123456789";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNumber = "12345";
            customer2.CompanyName = "Halo CO";
            customer2.TaxNumber = "987654321";

            //Individula and Corporate customer: different customer types
            //SOLID: L 

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}

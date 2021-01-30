using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter);
            customerManager.Save(new Customer { BirthDate= new DateTime(1985,1,6), FirstName="Jack", LastName="Silver", NationalID="123456789" });
             
        
        }
    }
}

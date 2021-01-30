﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to DB : " + customer.FirstName);
        
        }
    }
}

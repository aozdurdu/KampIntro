﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true; 
        }
    }
}

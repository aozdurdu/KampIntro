﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}

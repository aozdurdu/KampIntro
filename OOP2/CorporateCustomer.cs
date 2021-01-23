using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer //inheritance usage. It means "Corporate Customer is a Customer"
    {

        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}

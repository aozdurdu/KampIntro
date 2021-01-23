using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Credit payment plan is calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

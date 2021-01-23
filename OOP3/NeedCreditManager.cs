using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Need Credit payment plan is calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Evaluate application
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void MakeCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }

    }
}

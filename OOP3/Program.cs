using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
            //needCreditManager.Calculate();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService filebaseLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(vehicleCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager> {needCreditManager, vehicleCreditManager };
            //applicationManager.MakeCreditInformation(credits);

        }
    }
}

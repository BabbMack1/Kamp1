using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            //personalFinanceCredit.Calculate();

            TransportCreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculate();

            HomeCreditManager homeCreditManager = new HomeCreditManager();
            //homeCreditManager.Calculate();

            //Burada bu sekilde değil de aşağıdaki gibi yaptıgımızda da olacaktı. Interface onu impelement eden class'ın adresini tutar.
            //ICreditManager creditManager = new PersonalFinanceCredit();
            //creditManager.Calculate();

            ApplicationManager applicationManager = new ApplicationManager();
            ILoggerService loggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            applicationManager.Application(personalFinanceCredit,fileLoggerService); //Bu şekilde kullanabiliriz. Burada loggerService i list olarak gönderirsek birden fazla logger kullanabilmiş oluruz.
            //Bu şekilde kullandıgımızda hangi kredi girilirse hesaplama ona göre yapılıyor.

            List<ICreditManager> krediler = new List<ICreditManager>() {personalFinanceCredit,homeCreditManager }; //Bu şekilde kullandıgımızda Listede ne gönderirsek onu hesaplamış olacak
            //applicationManager.CreditInformation(krediler);
        }
    }
}

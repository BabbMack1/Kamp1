using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        public void Application(ICreditManager creditManager,ILoggerService loggerService)
        {
            //Burada bilgileri alırız.
            //HomeCreditManager homeCreditManager = new HomeCreditManager();
            //homeCreditManager.Calculate();
            ///Bunu bu şekilde kullanabiliriz. AMA BUNU YAPTIGIMIZDA BÜTÜN BASVURULAR KONUT KREDİSİ OLARAK HESAPLANIR.
            ///Bunun yerine yukarıda girdi olarak kredi alabiliriz.
            creditManager.Calculate();
            loggerService.log();
        }
        public void CreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
                
            }
        }
    }
}

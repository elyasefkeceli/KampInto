using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerService)
        {
            //basvuran bilgilendirmelerini değerlendirme.
            //
            creditManager.Hesapla();
            foreach (var loggerService1 in loggerService)
            {
                loggerService1.Log();
            }
        }
        public void CreditOnBilgilendirmeYap(List<ICreditManager>credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}

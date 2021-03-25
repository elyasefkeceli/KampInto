using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //elyase faruk keçeli
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "1234";
            customer1.FirstName = "faruk";
            customer1.LastName = "keceli";
            customer1.Identity = "5433535345353";
           
            //kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "43232";
            customer2.CompanyName = "kodlama.io";
            customer2.TaxNumber = "23232";
            //Gerçek Müşteri- Tüzel Müşteri
            //SO-L-İD

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}

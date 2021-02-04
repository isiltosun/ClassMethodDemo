using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.Forename = "Işıl";
            customer1.Surname = "Tosun";
            customer1.Age = 20;
            customer1.Gender = "Female";

            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.Forename = "Adsız";
            customer2.Surname = "Biri";
            customer2.Age = 25;
            customer2.Gender = "Male";

            Customer customer3 = new Customer();
            customer3.ID = 3;
            customer3.Forename = "Alelade";
            customer3.Surname = "Kimse";
            customer3.Age = 36;
            customer3.Gender = "Female";

            Customer customer4 = new Customer();
            customer4.ID = 4;
            customer4.Forename = "Herhangi";
            customer4.Surname = "Biri";
            customer4.Age = 42;
            customer4.Gender = "Male";

            Customer customer5 = new Customer();
            customer5.ID = 5;
            customer5.Forename = "İsimsiz";
            customer5.Surname = "Kimse";
            customer5.Age = 16;
            customer5.Gender = "Female";

            CustomerManager customer = new CustomerManager();
            customer.Add(customer1); //Müşteri ekleme
            customer.Add(customer2);
            customer.Add(customer3);
            customer.Add(customer4);
            customer.Add(customer5);

            customer.CustomerList(); //Müşteri listeleme

            customer.Delete(customer4); //Müşteri silme

            customer.CustomerList();
        }
    }
}


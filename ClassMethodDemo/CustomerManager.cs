using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public Customer[] customerArray;
        public Customer[] tempCustomerArray;

        public CustomerManager()
        {
            customerArray = new Customer[0];
        }

        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri ekleniyor. Müşteri ID'si: " + customer.ID);
            tempCustomerArray = customerArray;
            customerArray = new Customer[customerArray.Length + 1];

            for (int i = 0; i < tempCustomerArray.Length; i++)
            {
                customerArray[i] = tempCustomerArray[i];
            }

            customerArray[customerArray.Length - 1] = customer;
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("İstenilen müşteri (" + customer.ID + ". müşteri) siliniyor.");
            tempCustomerArray = customerArray;
            int indexNum = customer.ID - 1;

            for (int i = indexNum; i < customerArray.Length - 1; i++)
            {
                customerArray[i] = tempCustomerArray[i + 1];
            }

            tempCustomerArray = customerArray;
            customerArray = new Customer[customerArray.Length - 1];

            for (int j = 0; j < tempCustomerArray.Length - 1; j++)
            {
                customerArray[j] = tempCustomerArray[j];
            }

        }
        public void CustomerList()
        {
            Console.WriteLine("Müşteri ID listesi:");
            for (int i = 0; i < customerArray.Length; i++)
            {
                Console.WriteLine((customerArray[i]).ID);
            }

        }



    }
}

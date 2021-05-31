using AccountingDataLayer;
using AccountingDataLayer.Repositories;
using AccountingDataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customer = new CustomerRepository();

            Customers addCustomer = new Customers()
            {
                FullName = "احمد تمیزی",
                Mobile = "09365531447",
                CustomerImage = "Nono"
            };
            customer.InsertCustomer(addCustomer);
            customer.Save();

            var list = customer.GetAllCustomers();
        }
    }
}

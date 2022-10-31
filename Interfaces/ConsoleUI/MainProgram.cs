using System;
using System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceLibrary;

namespace ConsoleUI
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (PhysicalProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }
            Console.ReadLine();
        }
    }

    private static CustomerModel GetCustomer()
    {
        return new CustomerModel
        {
            FirstName = "Usama",
            LastName = "Raza",
            City = "Karachi",
            EmailAddress = "samayraza21@gmail.com",
            PhoneNumber = "090078601"

        };
    }
}
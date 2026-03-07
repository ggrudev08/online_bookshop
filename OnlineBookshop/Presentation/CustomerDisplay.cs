using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookshop.Presentation
{
    internal class CustomerDisplay
    {

        int closeOperationId = 6;
        private CustomerBusiness customerBusiness = new CustomerBusiness();

        public CustomerDisplay()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(new string(' ', 20) + "Customers" + new string(' ', 20));
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("1. All customers");
            Console.WriteLine("2. Add new customer");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Fetch customer by ID");
            Console.WriteLine("5. Delete customer by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AllList();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            customerBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Customer customer = customerBusiness.Get(id);
            if (customer != null)
            {
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("ID: " + customer.CustomerId);
                Console.WriteLine("Name: " + customer.FirstName + " " + customer.LastName);
                Console.WriteLine(new string('=', 50));
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Customer customer = customerBusiness.Get(id);
            if (customer != null)
            {
                Console.WriteLine("Enter first and last name: ");
                customer.FirstName = Console.ReadLine();
                customer.LastName = Console.ReadLine();

                customerBusiness.Update(customer);
                Console.WriteLine("Done.");
            }
            else
            {
                Console.WriteLine("Coach not found!");
            }
        }

        private void Add()
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter ID: ");
            customer.CustomerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            customer.FirstName = Console.ReadLine();
            customer.LastName = Console.ReadLine();
            customerBusiness.Add(customer);
            Console.WriteLine("Done.");
        }

        private void AllList()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(new string(' ', 20) + "Customers" + new string(' ', 20));
            Console.WriteLine(new string('=', 50));
            var customer = customerBusiness.GetAll();
            foreach (var item in customer)
            {
                Console.WriteLine($"ID: {item.CustomerId} | Name: {item.FirstName} {" "} {item.LastName}");
            }
        }

    }
}
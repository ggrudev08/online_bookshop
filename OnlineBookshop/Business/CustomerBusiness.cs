using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookshop.Business
{
    public class CustomerBusiness
    {
        private OnlineBookshopContext customerContex;
        public List<Customer> GetAll()
        {
            using (customerContex = new OnlineBookshopContext())
            {
                return customerContex.Customers.ToList();
            }
        }

        public Customer Get(int id)
        {
            using (customerContex = new OnlineBookshopContext())
            {
                var item = customerContex.Customers.Find(id);
                if (item == null)
                    throw new ArgumentException("Customer ID is not found!");

                return item;
            }
        }

        public void Add(Customer customer)
        {
            using (customerContex = new OnlineBookshopContext())
            {
                customerContex.Customers.Add(customer);
                customerContex.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using (customerContex = new OnlineBookshopContext())
            {
                var item = customerContex.Customers.Find(customer.CustomerId);
                if (item == null)
                    throw new ArgumentException("Item ID is not found!");

                customerContex.Entry(item).CurrentValues.SetValues(customer);
                customerContex.SaveChanges();
                
            }
        }

        public void Delete(int id)
        {
            using(customerContex = new OnlineBookshopContext())
            {
                var customers = customerContex.Customers.Find(id);
                if(customers != null)
                {
                    customerContex.Customers.Remove(customers);
                    customerContex.SaveChanges();
                }
            }
        }
    }
}

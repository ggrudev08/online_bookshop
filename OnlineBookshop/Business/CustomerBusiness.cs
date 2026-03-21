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
        private OnlineBookshopContext customerContext;
        public List<Customer> GetAll()
        {
            using (customerContext = new OnlineBookshopContext())
            {
                return customerContext.Customers.ToList();
            }
        }

        public Customer Get(int id)
        {
            using (customerContext = new OnlineBookshopContext())
            {
                var item = customerContext.Customers.Find(id);
                if (item == null)
                    throw new ArgumentException("Customer ID is not found!");

                return item;
            }
        }

        public void Add(Customer customer)
        {
            using (customerContext = new OnlineBookshopContext())
            {
                customerContext.Customers.Add(customer);
                customerContext.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using (customerContext = new OnlineBookshopContext())
            {
                var item = customerContext.Customers.Find(customer.CustomerId);
                if (item == null)
                    throw new ArgumentException("Item ID is not found!");

                customerContext.Entry(item).CurrentValues.SetValues(customer);
                customerContext.SaveChanges();
                
            }
        }

        public void Delete(int id)
        {
            using(customerContext = new OnlineBookshopContext())
            {
                var customers = customerContext.Customers.Find(id);
                if(customers != null)
                {
                    customerContext.Customers.Remove(customers);
                    customerContext.SaveChanges();
                }
            }
        }
    }
}

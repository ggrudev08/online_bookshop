using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Data.Models;

namespace OnlineBookshop.Business
{
    public class OrderBusiness
    {
        private OnlineBookshopContext orderContext;

        public List<Order> GetAll()
        {
            using (orderContext = new OnlineBookshopContext())
            {
                return orderContext.Orders.ToList();
            }
        }

        public Order Get(int id)
        {
            using (orderContext = new OnlineBookshopContext())
            {
                var item = orderContext.Authors.Find(id);
                if (item == null)
                    throw new ArgumentException("Order ID not found!");

                return orderContext.Orders.Find(id);
            }
        }

        public void Add(Order order)
        {
            using (orderContext = new OnlineBookshopContext())
            {
                orderContext.Orders.Add(order);
                orderContext.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            using (orderContext = new OnlineBookshopContext())
            {
                var item = orderContext.Authors.Find(order.OrderId);
                if (item == null)
                    throw new ArgumentException("Order ID not found!");

                orderContext.Entry(item).CurrentValues.SetValues(order);
                orderContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (orderContext = new OnlineBookshopContext())
            {
                var author = orderContext.Authors.Find(id);

                if (author == null)
                    throw new ArgumentException("Order ID not found!");

                orderContext.Authors.Remove(author);
                orderContext.SaveChanges();
            }
        }
    }
}

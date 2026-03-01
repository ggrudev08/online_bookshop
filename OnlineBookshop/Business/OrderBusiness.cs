using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Data.Models;

namespace OnlineBookshop.Business
{
    internal class OrderBusiness
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
                var item = orderContext.Orders.Find(order.OrderId);
                if (item != null)
                {
                    orderContext.Entry(order).CurrentValues.SetValues(order);
                    orderContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {

            using (orderContext = new OnlineBookshopContext())
            {
                var order = orderContext.Orders.Find(id);
                if (order != null)
                {
                    orderContext.Orders.Remove(order);
                    orderContext.SaveChanges();
                }
            }
        }
    }
}

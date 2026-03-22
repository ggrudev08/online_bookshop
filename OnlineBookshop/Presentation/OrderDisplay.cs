using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;

namespace OnlineBookshop.Presentation
{
    /// <summary>
    /// Handles the user interface display and interactions for Orders.
    /// </summary>
    public class OrderDisplay
    {
    
        int closeOperationId = 6;
        private OrderBusiness OrderBusiness = new OrderBusiness();
        public OrderDisplay()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(new string(' ', 20) + "Orders" + new string(' ', 20));
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("1. All orders");
            Console.WriteLine("2. Add new order");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Fetch order by ID");
            Console.WriteLine("5. Delete order by ID");
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
              OrderBusiness.Delete(id);
              Console.WriteLine("Done.");
            }


           private void Fetch()
            {
                Console.WriteLine("Enter ID to fetch: ");
                int id = int.Parse(Console.ReadLine());
                var order = OrderBusiness.Get(id);
                Console.WriteLine($"Order ID: {order.OrderId}, Customer ID: {order.CustomerId}");
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var order = OrderBusiness.Get(id);
            if (order != null)
            {
                Console.WriteLine("Enter new Customer ID: ");
                order.CustomerId = int.Parse(Console.ReadLine());
                OrderBusiness.Update(order);
                Console.WriteLine("Done.");
            }
        }

        private void Add()
        {
            var order = new Order();
            Console.WriteLine("Enter Customer ID: ");
            order.CustomerId = int.Parse(Console.ReadLine());
            OrderBusiness.Add(order);
            Console.WriteLine("Done.");
        }
        private void AllList()
        {
            var orders = OrderBusiness.GetAll();
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Customer ID: {order.CustomerId}");
            }
        }
    }
    
}

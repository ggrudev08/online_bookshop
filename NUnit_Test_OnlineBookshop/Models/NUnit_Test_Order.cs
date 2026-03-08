using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test_OnlineBookshop.Models
{

    [TestFixture]

    public class NUnit_Test_Order
    {

        private Order _order;
        
        [SetUp]
        public void Setup()
        {
            _order = new Order();
        }
    
    
        [Test]
        public void TestClassOrderIdIsNotLessThanOrEqualToZero()
        {
            Assert.Throws<ArgumentException>(() => _order.OrderId = -1);
        }

        [Test]

        public void TestClassOrdergreaterThanZero()
        {
            Assert.DoesNotThrow(() => _order.OrderId = 1);
        }

        [Test]
        public void TestOrderIdSetAndGetWorkCorrectly()
        {
            _order.OrderId = 5;
            Assert.That(_order.OrderId, Is.EqualTo(5));
        }

        [Test]
        public void TestOrderCustomerIdCanBeSet()
        {
            _order.CustomerId = 1;
            Assert.That(_order.CustomerId, Is.EqualTo(1));
        }

        [Test]
        public void TestOrderCustomerIdCanBeNull()
        {
            _order.CustomerId = null;
            Assert.That(_order.CustomerId, Is.Null);
        }

        [Test]
        public void TestOrderCustomerPropertyCanBeNull()
        {
            _order.Customer = null;
            Assert.That(_order.Customer, Is.Null);
        }

        [Test]
        public void TestOrderCustomerPropertyCanBeSet()
        {
            var customer = new Customer { CustomerId = 1, FirstName = "Test", LastName = "User" };
            _order.Customer = customer;
            Assert.That(_order.Customer, Is.EqualTo(customer));
        }

        [Test]
        public void TestOrderBooksCollectionIsInitialized()
        {
            Assert.That(_order.Books, Is.Not.Null);
            Assert.That(_order.Books, Is.InstanceOf<ICollection<Book>>());
        }

        [Test]
        public void TestOrderIdCannotBeZero()
        {
            Assert.Throws<ArgumentException>(() => _order.OrderId = 0);
        }

        [TearDown]
        public void TearDown()
        {
            _order = null;
        }
    }
}



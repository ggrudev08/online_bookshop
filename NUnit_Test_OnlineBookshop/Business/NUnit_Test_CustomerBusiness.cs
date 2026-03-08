using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop.Business
{
    [TestFixture]
    public class NUnit_Test_CustomerBusiness
    {
        private CustomerBusiness _customerBusiness;
        [SetUp]
        public void Setup()
        {
            _customerBusiness = new CustomerBusiness();
        }

        [Test]
        public void TestCustomerBusinessGetThrowsExceptionIfIdIsNotFound()
        {
            Assert.Throws<ArgumentException>(() => _customerBusiness.Get(-1));
        }

        [Test]
        public void TestCustomerBusinessGetDoesNotThrowExceptionIfIdIsFound()
        {
            Assert.DoesNotThrow(() => _customerBusiness.Get(1));
        }
        [Test]
        public void TestCustomerBusinessUpdateThrowsExceptionIfIdIsNotFound()
        {
            Customer customer = new Customer();
            Assert.Throws<ArgumentException>(() => _customerBusiness.Update(customer));
        }
        [Test]
        public void TestCustomerBusinessUpdateDoesNotThrowExceptionIfIdIsFound()
        {
            Customer customer = _customerBusiness.Get(1);
            Assert.DoesNotThrow(() => _customerBusiness.Update(customer));
        }

        [Test]
        public void TestCustomerBusinessGetAllReturnsListOfCustomers()
        {
            var customers = _customerBusiness.GetAll();
            Assert.That(customers, Is.Not.Null);
            Assert.That(customers, Is.InstanceOf<List<Customer>>());
        }

        [Test]
        public void TestCustomerBusinessDeleteDoesNotThrowExceptionIfIdIsNotFound()
        {
            Assert.DoesNotThrow(() => _customerBusiness.Delete(-1));
        }


        [TearDown]
        public void Cleanup()
        {
            _customerBusiness = null;
        }
    }
}

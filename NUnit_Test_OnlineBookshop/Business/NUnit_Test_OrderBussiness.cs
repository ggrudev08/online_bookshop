using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test_OnlineBookshop.Business
{
    [TestFixture]
    public class NUnit_Test_OrderBusiness
    {
        private OrderBusiness _orderBusiness;
        [SetUp]
        public void SetUp()
        {
            _orderBusiness = new OrderBusiness();
        }

        [Test]
        public void TestOrderBusinessGetThrowsExceptionIfIdIsNotFound()
        {
            Assert.Throws<ArgumentException>(() => _orderBusiness.Get(-1));
        }

        [Test]
        public void TestOrderBusinessGetDoesNotThrowExceptionIfIdIsFound()
        {
            Assert.DoesNotThrow(() => _orderBusiness.Get(1));
        }

        [Test]
        public void TestOrderBusinessDeleteThrowsExceptionIfIdIsNotFound()
        {
            Assert.Throws<ArgumentException>(() => _orderBusiness.Delete(-1));
        }

        [Test]
        public void TestOrderBusinessUpdateThrowsExceptionIfIdIsNotFound()
        {
            Order order = new Order();
            Assert.Throws<ArgumentException>(() => _orderBusiness.Update(order));
        }

        [Test]
        public void TestOrderBusinessUpdateDoesNotThrowExceptionIfIdIsFound()
        {
            Order order = _orderBusiness.Get(1);
            Assert.DoesNotThrow(() => _orderBusiness.Update(order));
        }

        [TearDown]
        public void Cleanup()
        {
            _orderBusiness = null;
        }
    }
}

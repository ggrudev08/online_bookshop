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

        [TearDown]
        public void TearDown()
        {
            _order = null;
        }
    }
}



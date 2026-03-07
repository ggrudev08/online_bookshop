using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test_OnlineBookshop
{

    [TestFixture]

    public class NUnit_Test_Order
    {

        private Order order;
        
        [SetUp]
        public void Setup()
        {
            order = new Order();
        }
    
    
        [Test]
        public void TestOrderIdIsNotLessThanOrEqualToZero()
        {
            Assert.Throws<ArgumentException>(() => order.OrderId = -1);
        }

        [TearDown]
        public void TearDown()
        {
            order = null;
        }
    }
}



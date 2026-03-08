using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop.Models
{
    [TestFixture]
    public class NUnit_Test_Customer
    {
        private Customer _customer;
        [SetUp]
        public void Setup()
        {
            _customer = new Customer();
        }

        [Test]
        public void TestClassCustomerCannotBeLessThanOrEqualToZero()
        {
            Assert.Throws<ArgumentException>(() => _customer.CustomerId = -1);
        }

        [Test]
        public void TestClassCustomerGreaterThanZero()
        {
            Assert.DoesNotThrow(() => _customer.CustomerId = 1);
        }
        public void TestCustomer()
        {
            Assert.Pass();
        }

        [TearDown]
        public void Cleanup()
        {
            _customer = null;
        }
    }
}
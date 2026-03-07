using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop
{
    [TestFixture]
    public class NUnit_Test_Customer
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestClassCustomerCannotBeLessThanOrEqualToZero()
        {
            Customer customer = new Customer();
            Assert.Throws<ArgumentException>(() => customer.CustomerId = -1);
        }

        [Test]
        public void TestClassCustomerGreaterThanZero()
        {
            Customer customer = new Customer();
            Assert.DoesNotThrow(() => customer.CustomerId = 1);
        }
        public void TestCustomer()
        {
            Assert.Pass();
        }
    }
}
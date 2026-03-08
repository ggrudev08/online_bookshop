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

        [Test]
        public void TestCustomerIdSetAndGetWorkCorrectly()
        {
            _customer.CustomerId = 5;
            Assert.That(_customer.CustomerId, Is.EqualTo(5));
        }

        [Test]
        public void TestCustomerFirstNamePropertyCanBeSet()
        {
            _customer.FirstName = "John";
            Assert.That(_customer.FirstName, Is.EqualTo("John"));
        }

        [Test]
        public void TestCustomerLastNamePropertyCanBeSet()
        {
            _customer.LastName = "Doe";
            Assert.That(_customer.LastName, Is.EqualTo("Doe"));
        }

        [Test]
        public void TestCustomerOrdersCollectionIsInitialized()
        {
            Assert.That(_customer.Orders, Is.Not.Null);
            Assert.That(_customer.Orders, Is.InstanceOf<ICollection<Order>>());
        }

        [Test]
        public void TestCustomerIdCannotBeZero()
        {
            Assert.Throws<ArgumentException>(() => _customer.CustomerId = 0);
        }

        [Test]
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
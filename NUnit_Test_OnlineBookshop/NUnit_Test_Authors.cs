using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop
{
    [TestFixture]
    public class NUnit_Test_Authors
    {
        private Author _author;

        [SetUp]
        public void Setup()
        {
             _author = new Author();
        }

        [Test]
        public void TestAuthorIdCannotBeLessThanOrEqualToZero()
        {
            Assert.Throws<ArgumentException>(() => _author.AuthorId = -1);
        }

        [Test]
        public void TestAuthorIdMoreThanZeroIsValid()
        {
            Assert.DoesNotThrow(() => _author.AuthorId = 1);
        }

        [Test]
        public void TestAuthorBirthYearCannotBeGreaterThan2026()
        {
            Assert.Throws<ArgumentException>(() => _author.BirthYear = 2027);
        }

        [Test]
        public void TestAuthorBirthYearLessThan2026IsValid()
        {
            Assert.DoesNotThrow(() => _author.BirthYear = 1980);
        }


        [TearDown]
        public void Cleanup()
        {
            _author = null;
        }

    }
}
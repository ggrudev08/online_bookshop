using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop.Models
{
    /// <summary>
    /// Tests for the Author model class.
    /// </summary>
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

        [Test]
        public void TestAuthorFirstNameCannotBeNull()
        {
            Assert.Throws<ArgumentException>(() => _author.FirstName = null);
        }

        [Test]
        public void TestAuthorFirstNameCannotBeEmpty()
        {
            Assert.Throws<ArgumentException>(() => _author.FirstName = "");
        }

        [Test]
        public void TestAuthorFirstNameCannotBeWhitespace()
        {
            Assert.Throws<ArgumentException>(() => _author.FirstName = "   ");
        }

        [Test]
        public void TestAuthorFirstNameIsValidWithProperValue()
        {
            Assert.DoesNotThrow(() => _author.FirstName = "John");
        }

        [Test]
        public void TestAuthorLastNameCannotBeNull()
        {
            Assert.Throws<ArgumentException>(() => _author.LastName = null);
        }

        [Test]
        public void TestAuthorLastNameCannotBeEmpty()
        {
            Assert.Throws<ArgumentException>(() => _author.LastName = "");
        }

        [Test]
        public void TestAuthorLastNameCannotBeWhitespace()
        {
            Assert.Throws<ArgumentException>(() => _author.LastName = "   ");
        }

        [Test]
        public void TestAuthorLastNameIsValidWithProperValue()
        {
            Assert.DoesNotThrow(() => _author.LastName = "Doe");
        }

        [Test]
        public void TestAuthorIdSetAndGetWorkCorrectly()
        {
            _author.AuthorId = 5;
            Assert.That(_author.AuthorId, Is.EqualTo(5));
        }

        [Test]
        public void TestAuthorBirthYearSetAndGetWorkCorrectly()
        {
            _author.BirthYear = 1990;
            Assert.That(_author.BirthYear, Is.EqualTo(1990));
        }

        [Test]
        public void TestAuthorBooksCollectionIsInitialized()
        {
            Assert.That(_author.Books, Is.Not.Null);
            Assert.That(_author.Books, Is.InstanceOf<ICollection<Book>>());
        }


        [TearDown]
        public void Cleanup()
        {
            _author = null;
        }

    }
}
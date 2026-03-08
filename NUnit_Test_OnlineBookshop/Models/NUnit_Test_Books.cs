using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop.Models
{
    [TestFixture]
    public class NUnit_Test_Books
    {
        private Book _book;

        [SetUp]
        public void SetUp()
        {
            _book = new Book();
        }

        [Test]
        public void TestBookIdCannotBeLessThanOrEqualToZero()
        {
            Assert.Throws<ArgumentException>(() => _book.BookId = -1);
        }

        [Test]
        public void TestBookIdMoreThanZeroIsValid()
        {
            Assert.DoesNotThrow(() => _book.BookId = 1);
        }

        [Test]
        public void TestBookPriceCannotBeLessThanZero()
        {
            Assert.Throws<ArgumentException>(() => _book.Price = -5);
        }

        [Test]
        public void TestBookPriceMoreThanZeroIsValid()
        {
            Assert.DoesNotThrow(() => _book.Price = 5);
        }

        [Test]
        public void TestBookReleaseYearCannotBeGreaterThan2026()
        {
            Assert.Throws<ArgumentException>(() => _book.ReleaseYear = 2027);
        }

        [Test]
        public void TestBookReleaseYearLessThan2026IsValid()
        {
            Assert.DoesNotThrow(() => _book.ReleaseYear = 2022);
        }

        [Test]
        public void TestBookIdSetAndGetWorkCorrectly()
        {
            _book.BookId = 10;
            Assert.That(_book.BookId, Is.EqualTo(10));
        }

        [Test]
        public void TestBookPriceSetAndGetWorkCorrectly()
        {
            _book.Price = 25.99m;
            Assert.That(_book.Price, Is.EqualTo(25.99m));
        }

        [Test]
        public void TestBookReleaseYearSetAndGetWorkCorrectly()
        {
            _book.ReleaseYear = 2020;
            Assert.That(_book.ReleaseYear, Is.EqualTo(2020));
        }

        [Test]
        public void TestBookNamePropertyCanBeSet()
        {
            _book.BookName = "Test Book";
            Assert.That(_book.BookName, Is.EqualTo("Test Book"));
        }

        [Test]
        public void TestBookGenrePropertyCanBeSet()
        {
            _book.Genre = "Science Fiction";
            Assert.That(_book.Genre, Is.EqualTo("Science Fiction"));
        }

        [Test]
        public void TestBookAuthorsCollectionIsInitialized()
        {
            Assert.That(_book.Authors, Is.Not.Null);
            Assert.That(_book.Authors, Is.InstanceOf<ICollection<Author>>());
        }

        [Test]
        public void TestBookOrdersCollectionIsInitialized()
        {
            Assert.That(_book.Orders, Is.Not.Null);
            Assert.That(_book.Orders, Is.InstanceOf<ICollection<Order>>());
        }

        [Test]
        public void TestBookPriceZeroIsValid()
        {
            Assert.DoesNotThrow(() => _book.Price = 0);
        }

        [Test]
        public void TestBookReleaseYearCanBeNull()
        {
            Assert.DoesNotThrow(() => _book.ReleaseYear = null);
        }

        [Test]
        public void TestBookReleaseYearEqualsTo2026IsValid()
        {
            Assert.DoesNotThrow(() => _book.ReleaseYear = 2026);
        }

        [TearDown]
        public void Cleanup()
        {
            _book = null;
        }
    }
}

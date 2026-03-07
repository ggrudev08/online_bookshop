using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop
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

        [TearDown]
        public void Cleanup()
        {
            _book = null;
        }
    }
}

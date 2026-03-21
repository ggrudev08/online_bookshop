using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop.Business
{
    /// <summary>
    /// Tests for the BookBusiness class.
    /// </summary>
    [TestFixture]
    public class NUnit_Test_BookBusiness
    {
        private BookBusiness _bookBusiness;

        [SetUp]
        public void Setup()
        {
            _bookBusiness = new BookBusiness();
        }

        [Test]
        public void TestBookBusinessGetThrowsExceptionIfIdIsNotFound()
        {
            Assert.Throws<ArgumentException>(() => _bookBusiness.Get(-1));
        }

        [Test]
        public void TestBookBusinessGetDoesNotThrowExceptionIfIdIsFound()
        {
            Assert.DoesNotThrow(() => _bookBusiness.Get(1));
        }

        [Test]
        public void TestBookBusinessGetAllReturnsListOfBooks()
        {
            var books = _bookBusiness.GetAll();
            Assert.That(books, Is.Not.Null);
            Assert.That(books, Is.InstanceOf<List<Book>>());
        }

        [Test]
        public void TestBookBusinessAddDoesNotThrowException()
        {
            var book = new Book
            {
                BookName = "Test Book",
                Genre = "Fiction",
                Price = 19.99m,
                ReleaseYear = 2023
            };
            Assert.DoesNotThrow(() => _bookBusiness.Add(book));

            // Cleanup: Remove the added book
            _bookBusiness.Delete(book.BookId);
        }

        [Test]
        public void TestBookBusinessUpdateDoesNotThrowExceptionIfIdIsFound()
        {
            var book = _bookBusiness.Get(1);
            Assert.DoesNotThrow(() => _bookBusiness.Update(book));
        }

        [Test]
        public void TestBookBusinessDeleteThrowsExceptionIfIdIsNotFound()
        {
            Assert.Throws<ArgumentException>(() => _bookBusiness.Delete(-1));
        }

        [TearDown]
        public void Cleanup()
        {
            _bookBusiness = null;
        }
    }
}

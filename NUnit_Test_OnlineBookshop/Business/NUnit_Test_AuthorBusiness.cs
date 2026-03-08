using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;

namespace NUnit_Test_OnlineBookshop.Business
{
    [TestFixture]
    public class NUnit_Test_AuthorBusiness
    {
        private AuthorBusiness _authorBusiness;
        [SetUp]
        public void SetUp()
        {
            _authorBusiness = new AuthorBusiness();
        }

        [Test]
        public void TestAuthorBusinessGetThrowsExceptionIfIdIsNotFound()
        {
            Assert.Throws<ArgumentException>(() => _authorBusiness.Get(-1));
        }

        [Test]
        public void TestAuthorBusinessGetDoesNotThrowExceptionIfIdIsFound()
        {
            Assert.DoesNotThrow(() => _authorBusiness.Get(1));
        }

        [Test]
        public void TestAuthorBusinessDeleteThrowsExceptionIfIdIsNotFound()
        {
            Assert.Throws<ArgumentException>(() => _authorBusiness.Delete(-1));
        }

        [Test]
        public void TestAuthorBusinessUpdateThrowsExceptionIfIdIsNotFound()
        {
            Author author = new Author();
            Assert.Throws<ArgumentException>(() => _authorBusiness.Update(author));
        }

        [Test]
        public void TestAuthorBusinessUpdateDoesNotThrowExceptionIfIdIsFound()
        {
            Author author = _authorBusiness.Get(1);
            Assert.DoesNotThrow(() => _authorBusiness.Update(author));
        }
        [TearDown]
        public void Cleanup()
        {
            _authorBusiness = null;
        }
    }
}

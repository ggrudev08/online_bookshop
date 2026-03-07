using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookshop.Business
{
    class BookBusiness
    {
        private OnlineBookshopContext bookContext;

        public List<Book> GetAll()
        {
            using (bookContext = new OnlineBookshopContext())
            {
                return bookContext.Books.ToList();
            }
        }
    
        public Book Get(int id)
        {
            using (bookContext = new OnlineBookshopContext())
            {
                return bookContext.Books.Find(id);
            }
        }
    
        public void Add(Book book)
        {
            using(bookContext = new OnlineBookshopContext())
            {
               bookContext.Books.Add(book);
               bookContext.SaveChanges();
            }
        }

        public void Update(Book book)
        {
            using (bookContext = new OnlineBookshopContext())
            {
                var item = bookContext.Books.Find(book.BookId);
                if(item != null)
                {
                    bookContext.Entry(item).CurrentValues.SetValues(book);
                    bookContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (bookContext = new OnlineBookshopContext())
            {
                var item = bookContext.Books.Find(id);
                if (item != null)
                {
                    bookContext.Books.Remove(item);
                    bookContext.SaveChanges();
                }
            }
        }

    }
}


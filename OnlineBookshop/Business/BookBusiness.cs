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
<<<<<<< HEAD
            
=======
>>>>>>> 7a83446655ab0336309df64f7b063b5e47b630d4
            using (bookContext = new OnlineBookshopContext())
            {
                var item = bookContext.Books.Find(id);
                if (item == null) throw new ArgumentException("Book id is null");
                return item;
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
                if(item == null) throw new ArgumentException("Book id is null");
                
                    bookContext.Entry(item).CurrentValues.SetValues(book);
                    bookContext.SaveChanges(); 

            }
        }
        public void Delete(int id)
        {
            using (bookContext = new OnlineBookshopContext())
            {
                var item = bookContext.Books.Find(id);
                if (item == null) throw new ArgumentException("Book id is null");

                    bookContext.Books.Remove(item);
                    bookContext.SaveChanges();
                
            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookshop.Data.Models;

namespace OnlineBookshop.Business
{
    internal class AuthorBusiness
    {
        private OnlineBookshopContext authorContext;

        public List<Author> GetAll()
        {
            using (authorContext = new OnlineBookshopContext())
            {
                return authorContext.Authors.ToList();
            }
        }

        public Author Get(int id)
        {
            using (authorContext = new OnlineBookshopContext())
            {
                return authorContext.Authors.Find(id);
            }

        }

        public void Add(Author author)
        {
            using (authorContext = new OnlineBookshopContext())
            {
                authorContext.Authors.Add(author);
                authorContext.SaveChanges();
            }
        }

        public void Update(Author author)
        {
            using (authorContext = new OnlineBookshopContext())
            {
                var item = authorContext.Authors.Find(author.AuthorId);
                if (item != null)
                {
                    authorContext.Entry(item).CurrentValues.SetValues(author);
                    authorContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (authorContext = new OnlineBookshopContext())
            {
                var author = authorContext.Authors.Find(id);
                if (author != null)
                {
                    authorContext.Authors.Remove(author);
                    authorContext.SaveChanges();
                }
            }
        }
    }
}

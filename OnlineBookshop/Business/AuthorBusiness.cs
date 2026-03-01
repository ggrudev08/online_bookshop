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

    }
}

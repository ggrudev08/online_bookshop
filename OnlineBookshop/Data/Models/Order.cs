using System;
using System.Collections.Generic;

namespace OnlineBookshop.Data.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}

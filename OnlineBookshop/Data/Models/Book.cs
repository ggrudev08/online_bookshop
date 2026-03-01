using System;
using System.Collections.Generic;

namespace OnlineBookshop.Data.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public decimal Price { get; set; }

    public int? ReleaseYear { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

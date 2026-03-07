using System;
using System.Collections.Generic;

namespace OnlineBookshop.Data.Models;

public partial class Book
{

    private int? _release_year;
    private decimal _price;
    private int _book_id;

    public int BookId
    {
        get => _book_id;

        set
        {
            if (value <= 0)
                throw new ArgumentException("Book Id cannot be less than 0");
            _book_id = value;
        }
    }

    public string BookName { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentException("Price cannot less than 0");
            _price = value;
        }
    }

    public int? ReleaseYear
    {
        get => _release_year;
        set
        {
            if (value > 2026)
                throw new ArgumentException("Release Year cannot be greater than 2026");
            _release_year = value;
        }

    }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

using System;
using System.Collections.Generic;

namespace OnlineBookshop.Data.Models;

public partial class Author
{

    private int? _birth_year;
    private int _author_id;

    public int AuthorId
    {
        get => _author_id;

        set
        {
            if (value <= 0)
                throw new ArgumentException("Author Id cannot be less than or equal to 0");
            _author_id = value;
        }
    }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? BirthYear
    {
        get => _birth_year;
        set
        {
            if (value > 2026)
                throw new ArgumentException("Birth Year cannot be greater than 2026.");
            _birth_year = value;
        }
    }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}

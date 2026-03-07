using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OnlineBookshop.Data.Models;

public partial class Author
{
    private int _author;
    private int _birthYear;
    private string _firstName;
    private string _lastName;

    public int AuthorId 
    {
        get => _author;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Author Id cannot be less or equal to 0 ");
            _author = value;
        }
            
            
    }

    public string FirstName 
    { 
        get=> _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name cannot be null!");
            _firstName = value;
        } 
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name cannot be null!");
            _lastName = value;
        }
    }

    public int BirthYear 
    { 
        get => _birthYear;

        set
        {
            if (value > 2026)
                throw new ArgumentException("The author birth year cannot be greater than 2026");
            _birthYear = value;
        } 
    }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
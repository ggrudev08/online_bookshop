using System;
using System.Collections.Generic;

namespace OnlineBookshop.Data.Models;

public partial class Customer
{
    private int _customerId;
    private string _firstName;
    private string _lastName;
    public int CustomerId 
    {
        get { return _customerId; }
        set 
        {
            if (value <= 0)
                throw new ArgumentException("Id should be biger than 0");
            _customerId = value;
        }
    }

    public string FirstName { get;set;} = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

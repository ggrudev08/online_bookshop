using System;
using System.Collections.Generic;

namespace OnlineBookshop.Data.Models;

/// <summary>
/// Represents an Order entity in the database.
/// </summary>
public partial class Order
{
    private int order_id;
    public int OrderId 
    { 
        get => order_id;

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("OrderId must be a positive nubmer.");
            }
            order_id = value;
        }
    }

    public int? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}

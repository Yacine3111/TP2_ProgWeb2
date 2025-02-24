﻿using Microsoft.EntityFrameworkCore;

namespace TP2.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int MenuItemId { get; set; }
    public int Quantity { get; set; }
    [Precision(18, 2)]
    public decimal UnitPrice { get; set; }

    // Navigation properties
    public Order Order { get; set; }
    public MenuItem MenuItem { get; set; }
}

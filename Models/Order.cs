using Microsoft.EntityFrameworkCore;

namespace TP2.Models;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int? TableId { get; set; } // Nullable pour les commandes à emporter
    public DateTimeOffset OrderTime { get; set; }
    public string Status { get; set; } // "En préparation", "Servi", "Payé"
    [Precision(18, 2)]
    public decimal TotalAmount { get; set; }

    // Navigation properties
    public Customer Customer { get; set; }
    public Table Table { get; set; }
    public IList<OrderItem> Items { get; set; } = new List<OrderItem>();
}

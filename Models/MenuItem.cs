using Microsoft.EntityFrameworkCore;

namespace TP2.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [Precision(18,2)]
    public decimal Price { get; set; }
    public string Category { get; set; } // "Entrée", "Plat principal", "Dessert", "Boisson"
    public bool IsAvailable { get; set; } = true;

    // Navigation properties
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}

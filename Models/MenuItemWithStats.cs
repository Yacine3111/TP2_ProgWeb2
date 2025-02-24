using System.ComponentModel.DataAnnotations.Schema;

namespace TP2.Models
{
    [NotMapped]
    public class MenuItemWithStats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        // Nombre total de produits commandées
        public int TotalOrdered { get; set; }
        // Prix total payé pour les produits commandés
        public decimal TotalRevenue { get; set; }
    }
}

namespace TP2.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    // Navigation properties
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}

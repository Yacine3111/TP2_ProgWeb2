namespace TP2.Models;

public class Reservation
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int TableId { get; set; }
    public DateTimeOffset ReservationTime { get; set; }
    public int GuestCount { get; set; }
    public string Status { get; set; } // "Confirmée", "En attente", "Annulée"

    // Navigation properties
    public Customer Customer { get; set; }
    public Table Table { get; set; }
}

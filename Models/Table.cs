namespace TP2.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; } // e.g., "Terrasse", "Salle principale", "Privé"
        public bool IsAvailable { get; set; } = true;

        // Navigation properties
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}

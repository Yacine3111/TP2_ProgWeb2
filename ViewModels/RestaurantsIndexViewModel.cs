using TP2.Models;

namespace TP2.ViewModels;

public class RestaurantsIndexViewModel
{
    public IEnumerable<Customer>? TopCustomers { get; set; }

    public IEnumerable<Table>? AvailableTablesForTimeSlot { get; set; }

    // Type à changer
    public IDictionary<string, int>? SalesByCategory { get; set; }

    public IEnumerable<MenuItemWithStats>? PopularMenuItems { get; set; }
}
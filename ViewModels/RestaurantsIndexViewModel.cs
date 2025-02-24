using TP2.Models;
using static TP2.Services.RestaurantsService;

namespace TP2.ViewModels;

public class RestaurantsIndexViewModel
{
    public IEnumerable<Customer>? TopCustomers { get; set; }

    public IEnumerable<Table>? AvailableTablesForTimeSlot { get; set; }

    // Type à changer
    public IEnumerable<object>? SalesByCategory { get; set; }

    public IEnumerable<MenuItemWithStats>? PopularMenuItems { get; set; }
}
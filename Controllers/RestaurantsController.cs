using Microsoft.AspNetCore.Mvc;
using TP2.Data;
using TP2.Services;
using TP2.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP2.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly RestaurantsService _service;

        public RestaurantsController(RestaurantsService service)
        {
            _service = service;
        }

        public IActionResult Index(int? topCustomerCount, DateTimeOffset? tableStartTime, int? tableGuestCount, DateTimeOffset? saleDate, DateTimeOffset? popularRefDate, int? popularDaysBefore, int? popularItemCount)
        {
            var fixedDate = DateTimeOffset.Parse("2024-12-17");

            var topCustomers = _service
                .GetTopCustomers()
                .Take(topCustomerCount.GetValueOrDefault(3));

            var availableTables = _service
                .GetAvailableTablesForTimeSlot(tableStartTime.GetValueOrDefault(fixedDate), tableGuestCount.GetValueOrDefault(3));

            var salesByCategory = _service
                .GetSalesByCategory(saleDate.GetValueOrDefault(fixedDate));

            var popularMenuItems = _service
                .GetPopularMenuItems(fixedDate, popularDaysBefore.GetValueOrDefault(30))
                .Take(popularItemCount.GetValueOrDefault(5));

            var vm = new RestaurantsIndexViewModel()
            {
                TopCustomers = topCustomers,
                AvailableTablesForTimeSlot = availableTables,
                SalesByCategory = salesByCategory,
                PopularMenuItems = popularMenuItems

            };
            return View(vm);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TP2.Data;
using TP2.Models;

namespace TP2.Services
{
    public class RestaurantsService
    {
        private readonly RestaurantDbContext _context;

        public RestaurantsService(RestaurantDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Renvoyez la liste des meilleurs clients basé sur leur nombre de commandes
        /// Assurez-vous d'être en mesure d'afficher le nombre de commandes dans la vue
        /// Le nombre de clients qu'on souhaite obtenir limité est par le Controller, assurez-vous que cette limite est appliquée dans la BD
        /// </summary>
        /// <returns></returns>
        public IOrderedQueryable<Customer> GetTopCustomers()
        {
            return _context.Customers
                    .Include(c => c.Orders)
                    .OrderByDescending(c => c.Orders.Count)
                ;
        }

        /// <summary>
        /// Retournez la liste de tables disponibles, dans la plage entre 2h avant et 2h après l'heure choisie
        /// Assurez-vous de tenir compte des réservations existantes et de choisir une table avec une capacité
        /// suffisante, mais en priorisant les tables avec le moins de places possibles!
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="guestCount"></param>
        /// <returns></returns>
        public IEnumerable<Table> GetAvailableTablesForTimeSlot(DateTimeOffset startTime, int guestCount)
        {
            var rangeBefore = startTime.AddHours(-2);
            var rangeAfter = startTime.AddHours(2);

            return _context.Reservations
                .Where(r => r.ReservationTime >= rangeBefore &&
                            r.ReservationTime <= rangeAfter)
                .Select(r => r.Table)
                .Where(t => t.IsAvailable)
                .Where(t => t.Capacity >= guestCount)
                .OrderBy(t => t.Capacity)
                .Distinct()
                .ToList();
        }

        /// <summary>
        /// Retournez les ventes par catégorie à une date précise
        /// Changez le type de retour de la méthode pour un type plus approprié
        /// Votre type doit contenir la catégorie et le montant
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public IDictionary<string, int> GetSalesByCategory(DateTimeOffset date)
        {

            return _context.OrderItems
                .Where(o => o.Order.OrderTime.Date == date.Date)
                .Select(o => new MenuItemWithStats()
                {
                    Id = o.MenuItemId,
                    Name = o.MenuItem.Name,
                    Category = o.MenuItem.Category,
                    Price = o.MenuItem.Price,
                    TotalOrdered = o.Quantity,
                    TotalRevenue = o.Quantity * o.UnitPrice

                })
                .GroupBy(o => o.Category)
                .ToDictionary(g => g.Key, g => g.Sum(x => x.TotalOrdered))
                ;

        }

        /// <summary>
        /// Retournez les items du menu les plus populaires, entre la date de référence et X jours avants 
        /// Populez l'object MenuItemWithStats avec les bonnes valeurs
        /// En ordre descendant de quantité et ensuite de prix
        /// Le nombre d'items du menu est limité le Controller, assurez-vous que c'est appliqué en mémoire
        /// </summary>
        /// <param name="referenceDate">La date de référence</param>
        /// <param name="daysBefore">Le nombre de jours précédant la date de référence</param>
        /// <returns></returns>
        public IOrderedEnumerable<MenuItemWithStats> GetPopularMenuItems(DateTimeOffset referenceDate, int daysBefore)
        {
            var dateBefore = referenceDate.AddDays(-daysBefore);




            return _context.OrderItems
                    .Include(o => o.MenuItem)
                    .Include(o => o.Order)
                    .AsEnumerable()
                    .Where(o => o.Order.OrderTime >= dateBefore &&
                                o.Order.OrderTime <= referenceDate)
                    .Select(o => o.MenuItem)
                    .Select(o => new MenuItemWithStats()
                    {
                        Id = o.Id,
                        Category = o.Category,
                        Name = o.Name,
                        Price = o.Price,
                        TotalOrdered = o.OrderItems.Count,
                        TotalRevenue = o.OrderItems.Sum(oi => oi.Quantity * o.Price)
                    })
                    .OrderByDescending(m => m.TotalOrdered)
                ;
        }

    }
}

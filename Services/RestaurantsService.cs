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
        public IEnumerable<Customer> GetTopCustomers()
        {
            // À compléter;
            return Array.Empty<Customer>();

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
            // À compléter
            return Array.Empty<Table>();
        }

        /// <summary>
        /// Retournez les ventes par catégorie à une date précise
        /// Changez le type de retour de la méthode pour un type plus approprié
        /// Votre type doit contenir la catégorie et le montant
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public IEnumerable<object> GetSalesByCategory(DateTimeOffset date)
        {
            // À compléter
            return Array.Empty<object>();
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
        public IEnumerable<MenuItemWithStats> GetPopularMenuItems(DateTimeOffset referenceDate, int daysBefore)
        {
            return Array.Empty<MenuItemWithStats>();
        }

    }
}

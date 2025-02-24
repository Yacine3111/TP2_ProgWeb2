using Bogus;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using TP2.Models;

namespace TP2.Data
{
    public class DataGenerator
    {

    
        public DataGenerator(int seed = 12345)
        {
            Randomizer.Seed = new Random(seed);
        }

        public void SeedEverything(ModelBuilder modelBuilder)
        {
            SeedCustomers(modelBuilder);
            var menuItems = SeedMenu(modelBuilder);
            var tables = SeedTables(modelBuilder);
            SeedReservations(modelBuilder, tables);
            SeedOrders(modelBuilder, menuItems);
        }

        // Générez les clients
        public IList<Customer> SeedCustomers(ModelBuilder modelBuilder)
        {
            return Array.Empty<Customer>();
        }


        // Générez les items du menu
        public IList<MenuItem> SeedMenu(ModelBuilder modelBuilder)
        {
            var menuItemFaker = new Faker<MenuItem>()
                .RuleFor(m => m.Name, (f, m) =>
                {
                    return m.Category switch
                    {
                        "Entrée" => f.Food().Starter(),
                        "Plat principal" => f.Food().Meal(),
                        "Boisson" => f.Food().Drink(),
                        "Dessert" => f.Food().Dessert(),
                        _ => f.Commerce.ProductName(),
                    };
                });

            return Array.Empty<MenuItem>();
            
        }

        // Générez les tables
        public IList<Table> SeedTables(ModelBuilder modelBuilder)
        {
            return Array.Empty<Table>();
        }



        // Générez les réservations
        public IList<Reservation> SeedReservations(ModelBuilder modelBuilder, IList<Table> tables)
        {
            return Array.Empty<Reservation>();
        }

        // Générez les commandes et les items de commandes
        public IList<Order> SeedOrders(ModelBuilder modelBuilder, IList<MenuItem> menuItems)
        {
            return Array.Empty<Order>();
        }

    }
}

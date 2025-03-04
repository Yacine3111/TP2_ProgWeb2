using Bogus;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
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
            var customerFaker = new Faker<Customer>()
                .RuleFor(c => c.Id, f => f.IndexFaker + 1)
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName))
                .RuleFor(c => c.CreatedAt, f => f.Date.BetweenOffset(DateTimeOffset.Parse("2024-02-1"), DateTimeOffset.Parse("2025-02-1")));


            var listCustomer = customerFaker.Generate(50);

            modelBuilder.Entity<Customer>()
                .HasData(listCustomer);

            return listCustomer;
        }


        // Générez les items du menu
        public IList<MenuItem> SeedMenu(ModelBuilder modelBuilder)
        {
            IEnumerable<string> enumerableCategory = ["Entrée", "Plat principal", "Dessert", "Boisson"];

            var menuItemFaker = new Faker<MenuItem>()
                .RuleFor(m => m.Id, f => f.IndexFaker + 1)
                .RuleFor(m => m.Category, f => f.PickRandom(enumerableCategory))
                .RuleFor(m => m.Price, f => f.Random.Decimal(5.99m, 29.99m))
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
                })
                .RuleFor(m => m.Description, f => f.Lorem.Sentence())
                .RuleFor(m => m.IsAvailable, f => f.Random.Bool(0.9f));

            var listMenuItem = menuItemFaker.Generate(30);
            modelBuilder.Entity<MenuItem>()
                .HasData(listMenuItem);

            return listMenuItem;

        }

        // Générez les tables
        public IList<Table> SeedTables(ModelBuilder modelBuilder)
        {
            int[] places = [2, 4, 6, 8];
            float[] weight = [0.33f, 0.33f, 0.22f, 0.11f];
            IEnumerable<string> enumerableLocation = ["Terrasse", "Salle principale", "Coin fenêtre", "Privé"];


            var tableFaker = new Faker<Table>()
                .RuleFor(t => t.Id, f => f.IndexFaker + 1)
                .RuleFor(t => t.Number, f => f.IndexFaker + 1)
                .RuleFor(t => t.Capacity, f => f.Random.WeightedRandom(places, weight))
                .RuleFor(t => t.Location, f => f.PickRandom(enumerableLocation))
                .RuleFor(t => t.IsAvailable, f => f.Random.Bool());

            var listTable = tableFaker.Generate(20);

            modelBuilder.Entity<Table>()
                .HasData(listTable);

            return listTable;
        }



        // Générez les réservations
        public IList<Reservation> SeedReservations(ModelBuilder modelBuilder, IList<Table> tables)
        {
            IEnumerable<string> enumerableStatus = ["En attente", "Confirmée", "Annulée"];

            var reservationFaker = new Faker<Reservation>()
                .RuleFor(r => r.Id, f => f.IndexFaker + 1)
                .RuleFor(r => r.CustomerId, f => f.Random.Int(1, 50))
                .RuleFor(c => c.ReservationTime, f => f.Date.BetweenOffset(DateTimeOffset.Parse("2024-12-1"), DateTimeOffset.Parse("2025-02-1")))
                .RuleFor(c => c.GuestCount, f => f.Random.Int(1, 10))
                .RuleFor(c => c.Status, f => f.PickRandom(enumerableStatus))
                .RuleFor(c => c.TableId, (f, c) =>
                {
                    var suitableTables = tables.Where(t => t.Capacity >= c.GuestCount && t.IsAvailable).ToList();
                    Table? table;

                    if (suitableTables.Count == 0)
                    {
                        table = tables.MaxBy(t => t.Capacity);
                        c.GuestCount = table.Capacity;
                    }
                    else
                    {
                        table = f.PickRandom(suitableTables);

                    }
                    return table.Id;
                });

            var listReservation = reservationFaker.Generate(100);

            modelBuilder.Entity<Reservation>()
                .HasData(listReservation);

            return listReservation;
        }

        // Générez les commandes et les items de commandes
        public IList<Order> SeedOrders(ModelBuilder modelBuilder, IList<MenuItem> menuItems)
        {
            var orderItemFaker = new Faker<OrderItem>()
                .RuleFor(oi => oi.Id, f => f.IndexFaker + 1)
                .RuleFor(oi => oi.MenuItemId, f => f.Random.Int(1, 30))
                .RuleFor(oi => oi.Quantity, f => f.Random.Int(1, 3))
                .RuleFor(oi => oi.UnitPrice, (f, oi) =>
                {
                    var item = menuItems.FirstOrDefault(m => m.Id == oi.MenuItemId);

                    return item.Price;
                });

            IEnumerable<string> enumerableStatus = ["En préparation", "Servi", "Payé"];
            IList<OrderItem> items = new List<OrderItem>();

            var orderFaker = new Faker<Order>()
                .RuleFor(o => o.Id, f => f.IndexFaker + 1)
                .RuleFor(o => o.OrderTime, f => f.Date.BetweenOffset(DateTimeOffset.Parse("2024-12-1"), DateTimeOffset.Parse("2025-02-1")))
                .RuleFor(o => o.Status, f => f.PickRandom(enumerableStatus))
                .RuleFor(o => o.CustomerId, f => f.Random.Int(1, 50))
                .RuleFor(o => o.TableId, f => f.Random.Int(1, 20))
                .RuleFor(o => o.Items, (f, o) =>
                {
                    var newItems = orderItemFaker.GenerateBetween(2, 4);
                    foreach (var item in newItems)
                    {
                        item.OrderId = o.Id;
                    }

                    items.AddRange(newItems);

                    return null;

                })
                .RuleFor(o => o.TotalAmount, (f, o) =>
                {
                    var total = items.Where(x => x.OrderId == o.Id).Sum(i => i.Quantity * i.UnitPrice);

                    return total;
                });
            var listOrder = orderFaker.Generate(200);

            modelBuilder.Entity<OrderItem>()
                .HasData(items);

            modelBuilder.Entity<Order>()
                .HasData(listOrder);

            return listOrder;
        }

    }
}

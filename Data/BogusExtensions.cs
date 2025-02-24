using Bogus;
using Bogus.Premium;

namespace TP2.Data
{
    public static class BogusExtensions
    {
        public static Food Food(this Faker faker)
        {
            return ContextHelper.GetOrSet(faker, () => new Food());
        }
    }

    public class Food : DataSet
    {
        private static readonly string[] Starters = { "Salade verte", "Salade césar", "Tartare de betteraves" };

        private static readonly string[] Meals = { "Burger de poulet", "Bavette de boeuf", "Tataki de saumon", "Aubergines farcies" };

        private static readonly string[] Drinks = { "Boisson gazeuse", "Eau", "Bière", "Vin blanc", "Vin rouge", "Café", "Limonade", "Lait" };

        private static readonly string[] Desserts = { "Muffin aux bleuets", "Gâteau au chocolat", "Jell-O aux cerises" };

        public string Starter()

        {
            return Random.ArrayElement(Starters);
        }


        public string Meal()

        {
            return Random.ArrayElement(Meals);
        }

        public string Drink()
        {
            return Random.ArrayElement(Drinks);
        }

        public string Dessert()
        {
            return Random.ArrayElement(Desserts);
        }

    }
}

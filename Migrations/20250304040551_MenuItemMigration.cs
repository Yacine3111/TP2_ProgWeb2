using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP2.Migrations
{
    /// <inheritdoc />
    public partial class MenuItemMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Boisson", "Aut in itaque atque eveniet similique minima aperiam omnis non.", false, "Bière", 20.81197988350968800m },
                    { 2, "Boisson", "Quisquam saepe occaecati delectus voluptatum officiis doloremque autem sit quisquam.", false, "Boisson gazeuse", 21.05852739633459200m },
                    { 3, "Boisson", "Architecto provident explicabo quas doloribus et.", true, "Café", 9.88394521894582400m },
                    { 4, "Entrée", "Consequatur provident aut aliquam consequatur aut officiis pariatur id.", true, "Tartare de betteraves", 7.662214560989391200m },
                    { 5, "Entrée", "Pariatur velit et.", true, "Tartare de betteraves", 21.63894501103505600m },
                    { 6, "Boisson", "Voluptatem eos ea est quia.", true, "Boisson gazeuse", 23.38768144180889600m },
                    { 7, "Entrée", "Tempora rerum et et sunt omnis.", true, "Tartare de betteraves", 10.27535815900440800m },
                    { 8, "Entrée", "Non voluptas aut.", true, "Salade verte", 29.27488773819286400m },
                    { 9, "Plat principal", "Iusto dolorem perferendis porro distinctio numquam libero.", true, "Tataki de saumon", 9.32802476680745600m },
                    { 10, "Plat principal", "Molestiae ut repellendus nihil dolor et aliquid fuga.", true, "Aubergines farcies", 24.17132431161651200m },
                    { 11, "Entrée", "Ut odit exercitationem occaecati velit est voluptatibus sed natus.", true, "Tartare de betteraves", 24.93670494783051200m },
                    { 12, "Plat principal", "Veniam et voluptates in.", true, "Aubergines farcies", 11.16619491982097600m },
                    { 13, "Entrée", "Inventore blanditiis aspernatur sequi temporibus aut praesentium iure.", true, "Salade césar", 20.31585341405396000m },
                    { 14, "Plat principal", "Quis sit ut.", true, "Bavette de boeuf", 27.91833901472777600m },
                    { 15, "Boisson", "Et quia magnam aperiam et.", true, "Limonade", 10.27360098799858400m },
                    { 16, "Entrée", "Quia laborum iusto labore veritatis ipsam similique.", true, "Salade césar", 21.57907213787969600m },
                    { 17, "Dessert", "A aut vel quia sed culpa dolores quia dignissimos quam.", true, "Jell-O aux cerises", 8.382505665492502400m },
                    { 18, "Plat principal", "Quia quisquam aliquam non id rerum quisquam nihil dolor.", true, "Burger de poulet", 19.35153169225973600m },
                    { 19, "Entrée", "Culpa et assumenda esse deserunt magnam.", true, "Salade césar", 12.39441257059779200m },
                    { 20, "Entrée", "Sequi aut explicabo temporibus eum ab nobis vel.", true, "Salade verte", 27.34875990491302400m },
                    { 21, "Plat principal", "Magni sapiente labore corporis doloremque quas ea ipsam voluptates eos.", true, "Bavette de boeuf", 17.31135247593809600m },
                    { 22, "Boisson", "Repellat animi eveniet eum quasi ut qui fugiat et sint.", false, "Lait", 6.389738360382495200m },
                    { 23, "Dessert", "Perferendis odit enim.", true, "Gâteau au chocolat", 16.72101625346160800m },
                    { 24, "Plat principal", "Adipisci iure omnis ex dolore dolore tempora doloribus vel architecto.", true, "Burger de poulet", 21.11372027296745600m },
                    { 25, "Boisson", "Ut ut unde consequuntur laborum iure beatae debitis.", false, "Vin rouge", 26.90613534694356800m },
                    { 26, "Boisson", "Corrupti eos est suscipit maiores nam nihil dignissimos nostrum.", true, "Limonade", 25.07465321505658400m },
                    { 27, "Plat principal", "Qui unde qui quidem et laudantium totam beatae non id.", true, "Bavette de boeuf", 20.0792692571921600m },
                    { 28, "Plat principal", "Qui dolores qui in rem et tempore.", true, "Burger de poulet", 19.19165011901484800m },
                    { 29, "Plat principal", "Adipisci earum neque quia ut non praesentium recusandae voluptas.", true, "Burger de poulet", 25.90762123811878400m },
                    { 30, "Entrée", "Velit est tenetur fugiat qui.", true, "Salade césar", 19.26060542128541600m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}

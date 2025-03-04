using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP2.Migrations
{
    /// <inheritdoc />
    public partial class ClientMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 11, 29, 19, 4, 33, 702, DateTimeKind.Unspecified).AddTicks(544), new TimeSpan(0, -5, 0, 0, 0)), "Annabelle_Bernier@hotmail.com", "Annabelle", "Bernier" },
                    { 2, new DateTimeOffset(new DateTime(2024, 6, 21, 16, 38, 29, 953, DateTimeKind.Unspecified).AddTicks(454), new TimeSpan(0, -5, 0, 0, 0)), "Cassidy.Rippin@gmail.com", "Cassidy", "Rippin" },
                    { 3, new DateTimeOffset(new DateTime(2024, 12, 12, 3, 54, 28, 41, DateTimeKind.Unspecified).AddTicks(6247), new TimeSpan(0, -5, 0, 0, 0)), "Crystel.Aufderhar88@gmail.com", "Crystel", "Aufderhar" },
                    { 4, new DateTimeOffset(new DateTime(2024, 8, 31, 10, 53, 27, 324, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, -5, 0, 0, 0)), "Flossie_Braun@yahoo.com", "Flossie", "Braun" },
                    { 5, new DateTimeOffset(new DateTime(2024, 10, 9, 4, 51, 18, 414, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, -5, 0, 0, 0)), "Liliane.Reynolds@hotmail.com", "Liliane", "Reynolds" },
                    { 6, new DateTimeOffset(new DateTime(2024, 2, 1, 22, 39, 12, 250, DateTimeKind.Unspecified).AddTicks(5127), new TimeSpan(0, -5, 0, 0, 0)), "Cortez77@yahoo.com", "Cortez", "Larson" },
                    { 7, new DateTimeOffset(new DateTime(2024, 5, 14, 14, 13, 40, 346, DateTimeKind.Unspecified).AddTicks(1811), new TimeSpan(0, -5, 0, 0, 0)), "Jayson.King26@yahoo.com", "Jayson", "King" },
                    { 8, new DateTimeOffset(new DateTime(2024, 9, 23, 20, 0, 38, 131, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, -5, 0, 0, 0)), "Lorine.Grimes85@yahoo.com", "Lorine", "Grimes" },
                    { 9, new DateTimeOffset(new DateTime(2024, 10, 18, 8, 58, 37, 408, DateTimeKind.Unspecified).AddTicks(2281), new TimeSpan(0, -5, 0, 0, 0)), "Levi53@yahoo.com", "Levi", "Kiehn" },
                    { 10, new DateTimeOffset(new DateTime(2024, 6, 4, 9, 30, 7, 485, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, -5, 0, 0, 0)), "Annamae41@gmail.com", "Annamae", "Waters" },
                    { 11, new DateTimeOffset(new DateTime(2024, 6, 13, 5, 51, 25, 25, DateTimeKind.Unspecified).AddTicks(9775), new TimeSpan(0, -5, 0, 0, 0)), "Adriel_Schuppe76@gmail.com", "Adriel", "Schuppe" },
                    { 12, new DateTimeOffset(new DateTime(2024, 9, 26, 19, 9, 38, 268, DateTimeKind.Unspecified).AddTicks(952), new TimeSpan(0, -5, 0, 0, 0)), "Myrna_Rath@yahoo.com", "Myrna", "Rath" },
                    { 13, new DateTimeOffset(new DateTime(2024, 12, 19, 0, 18, 12, 59, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, -5, 0, 0, 0)), "Destiny25@gmail.com", "Destiny", "Blanda" },
                    { 14, new DateTimeOffset(new DateTime(2024, 2, 8, 15, 3, 54, 329, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, -5, 0, 0, 0)), "Kiana76@yahoo.com", "Kiana", "Little" },
                    { 15, new DateTimeOffset(new DateTime(2024, 6, 23, 8, 14, 33, 976, DateTimeKind.Unspecified).AddTicks(9403), new TimeSpan(0, -5, 0, 0, 0)), "Jackie_Rau27@gmail.com", "Jackie", "Rau" },
                    { 16, new DateTimeOffset(new DateTime(2024, 7, 5, 14, 44, 38, 885, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, -5, 0, 0, 0)), "Eldora_Brown@gmail.com", "Eldora", "Brown" },
                    { 17, new DateTimeOffset(new DateTime(2024, 4, 5, 16, 35, 14, 602, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -5, 0, 0, 0)), "Loyce93@hotmail.com", "Loyce", "Bogan" },
                    { 18, new DateTimeOffset(new DateTime(2025, 1, 30, 4, 2, 27, 597, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, -5, 0, 0, 0)), "Annalise63@yahoo.com", "Annalise", "Stanton" },
                    { 19, new DateTimeOffset(new DateTime(2024, 11, 1, 4, 31, 1, 541, DateTimeKind.Unspecified).AddTicks(940), new TimeSpan(0, -5, 0, 0, 0)), "Lukas_Walsh41@gmail.com", "Lukas", "Walsh" },
                    { 20, new DateTimeOffset(new DateTime(2024, 11, 20, 20, 58, 4, 591, DateTimeKind.Unspecified).AddTicks(9707), new TimeSpan(0, -5, 0, 0, 0)), "Demarcus30@gmail.com", "Demarcus", "Stanton" },
                    { 21, new DateTimeOffset(new DateTime(2024, 2, 2, 16, 44, 7, 695, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, -5, 0, 0, 0)), "Carmel_Cummings@hotmail.com", "Carmel", "Cummings" },
                    { 22, new DateTimeOffset(new DateTime(2024, 11, 5, 9, 9, 58, 721, DateTimeKind.Unspecified).AddTicks(8534), new TimeSpan(0, -5, 0, 0, 0)), "Leora_Koch@hotmail.com", "Leora", "Koch" },
                    { 23, new DateTimeOffset(new DateTime(2024, 7, 10, 8, 20, 38, 470, DateTimeKind.Unspecified).AddTicks(1153), new TimeSpan(0, -5, 0, 0, 0)), "Hilma.Orn7@hotmail.com", "Hilma", "Orn" },
                    { 24, new DateTimeOffset(new DateTime(2024, 7, 13, 20, 5, 28, 801, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, -5, 0, 0, 0)), "Henriette.Weimann@hotmail.com", "Henriette", "Weimann" },
                    { 25, new DateTimeOffset(new DateTime(2024, 6, 13, 2, 13, 44, 131, DateTimeKind.Unspecified).AddTicks(6967), new TimeSpan(0, -5, 0, 0, 0)), "Emerson_Spencer@hotmail.com", "Emerson", "Spencer" },
                    { 26, new DateTimeOffset(new DateTime(2024, 7, 31, 9, 33, 3, 445, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, -5, 0, 0, 0)), "Alexandro.Lakin8@gmail.com", "Alexandro", "Lakin" },
                    { 27, new DateTimeOffset(new DateTime(2024, 5, 25, 20, 55, 3, 41, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, -5, 0, 0, 0)), "Rod_Goodwin@gmail.com", "Rod", "Goodwin" },
                    { 28, new DateTimeOffset(new DateTime(2024, 10, 5, 21, 40, 17, 249, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, -5, 0, 0, 0)), "Heber_Bogan54@yahoo.com", "Heber", "Bogan" },
                    { 29, new DateTimeOffset(new DateTime(2024, 11, 22, 2, 52, 34, 51, DateTimeKind.Unspecified).AddTicks(4681), new TimeSpan(0, -5, 0, 0, 0)), "Clinton.Morar82@hotmail.com", "Clinton", "Morar" },
                    { 30, new DateTimeOffset(new DateTime(2024, 5, 1, 22, 12, 2, 903, DateTimeKind.Unspecified).AddTicks(8879), new TimeSpan(0, -5, 0, 0, 0)), "Susie.Fahey28@gmail.com", "Susie", "Fahey" },
                    { 31, new DateTimeOffset(new DateTime(2024, 10, 5, 8, 18, 14, 349, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, -5, 0, 0, 0)), "Nora_Funk61@gmail.com", "Nora", "Funk" },
                    { 32, new DateTimeOffset(new DateTime(2024, 2, 12, 10, 20, 12, 724, DateTimeKind.Unspecified).AddTicks(9489), new TimeSpan(0, -5, 0, 0, 0)), "Dayne.Cummerata@yahoo.com", "Dayne", "Cummerata" },
                    { 33, new DateTimeOffset(new DateTime(2024, 11, 25, 17, 58, 37, 693, DateTimeKind.Unspecified).AddTicks(2547), new TimeSpan(0, -5, 0, 0, 0)), "Nikita85@hotmail.com", "Nikita", "Hettinger" },
                    { 34, new DateTimeOffset(new DateTime(2024, 8, 11, 8, 48, 16, 143, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, -5, 0, 0, 0)), "Stanton.Cummerata@yahoo.com", "Stanton", "Cummerata" },
                    { 35, new DateTimeOffset(new DateTime(2024, 3, 17, 20, 14, 25, 844, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, -5, 0, 0, 0)), "Christopher.Gottlieb@yahoo.com", "Christopher", "Gottlieb" },
                    { 36, new DateTimeOffset(new DateTime(2024, 5, 1, 6, 28, 0, 311, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, -5, 0, 0, 0)), "Isabella_Kutch@gmail.com", "Isabella", "Kutch" },
                    { 37, new DateTimeOffset(new DateTime(2024, 7, 14, 8, 23, 31, 866, DateTimeKind.Unspecified).AddTicks(2379), new TimeSpan(0, -5, 0, 0, 0)), "Rubie95@hotmail.com", "Rubie", "Wisozk" },
                    { 38, new DateTimeOffset(new DateTime(2024, 5, 11, 22, 3, 6, 201, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, -5, 0, 0, 0)), "Jayda.Koelpin54@gmail.com", "Jayda", "Koelpin" },
                    { 39, new DateTimeOffset(new DateTime(2024, 6, 6, 4, 29, 23, 226, DateTimeKind.Unspecified).AddTicks(7610), new TimeSpan(0, -5, 0, 0, 0)), "Annie.Batz@gmail.com", "Annie", "Batz" },
                    { 40, new DateTimeOffset(new DateTime(2024, 9, 18, 14, 27, 3, 235, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, -5, 0, 0, 0)), "Lizeth.Osinski8@yahoo.com", "Lizeth", "Osinski" },
                    { 41, new DateTimeOffset(new DateTime(2024, 3, 8, 12, 24, 2, 868, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, -5, 0, 0, 0)), "Anabel_Gorczany@hotmail.com", "Anabel", "Gorczany" },
                    { 42, new DateTimeOffset(new DateTime(2024, 4, 17, 15, 16, 52, 644, DateTimeKind.Unspecified).AddTicks(8649), new TimeSpan(0, -5, 0, 0, 0)), "Justine_Prosacco89@gmail.com", "Justine", "Prosacco" },
                    { 43, new DateTimeOffset(new DateTime(2024, 4, 24, 10, 50, 41, 913, DateTimeKind.Unspecified).AddTicks(8211), new TimeSpan(0, -5, 0, 0, 0)), "Vivienne.Considine@hotmail.com", "Vivienne", "Considine" },
                    { 44, new DateTimeOffset(new DateTime(2024, 3, 14, 4, 56, 57, 754, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, -5, 0, 0, 0)), "Alvina17@gmail.com", "Alvina", "Harvey" },
                    { 45, new DateTimeOffset(new DateTime(2024, 5, 10, 4, 0, 20, 893, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, -5, 0, 0, 0)), "Willy.Hahn@gmail.com", "Willy", "Hahn" },
                    { 46, new DateTimeOffset(new DateTime(2024, 8, 3, 17, 48, 35, 45, DateTimeKind.Unspecified).AddTicks(4671), new TimeSpan(0, -5, 0, 0, 0)), "Laisha.Volkman@gmail.com", "Laisha", "Volkman" },
                    { 47, new DateTimeOffset(new DateTime(2024, 11, 30, 4, 4, 28, 170, DateTimeKind.Unspecified).AddTicks(8985), new TimeSpan(0, -5, 0, 0, 0)), "Jimmie57@hotmail.com", "Jimmie", "Shanahan" },
                    { 48, new DateTimeOffset(new DateTime(2024, 10, 7, 21, 48, 40, 203, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, -5, 0, 0, 0)), "Camille.Hudson48@yahoo.com", "Camille", "Hudson" },
                    { 49, new DateTimeOffset(new DateTime(2024, 2, 6, 19, 48, 19, 678, DateTimeKind.Unspecified).AddTicks(355), new TimeSpan(0, -5, 0, 0, 0)), "Viva29@gmail.com", "Viva", "Haag" },
                    { 50, new DateTimeOffset(new DateTime(2024, 3, 18, 13, 30, 37, 251, DateTimeKind.Unspecified).AddTicks(8021), new TimeSpan(0, -5, 0, 0, 0)), "Claire_Schaden32@yahoo.com", "Claire", "Schaden" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}

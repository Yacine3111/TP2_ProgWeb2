using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP2.Migrations
{
    /// <inheritdoc />
    public partial class TableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Location", "Number" },
                values: new object[,]
                {
                    { 1, 4, true, "Privé", 1 },
                    { 2, 6, true, "Privé", 2 },
                    { 3, 8, true, "Salle principale", 3 },
                    { 4, 2, false, "Salle principale", 4 },
                    { 5, 2, true, "Coin fenêtre", 5 },
                    { 6, 2, false, "Salle principale", 6 },
                    { 7, 8, true, "Terrasse", 7 },
                    { 8, 2, false, "Terrasse", 8 },
                    { 9, 2, true, "Privé", 9 },
                    { 10, 2, true, "Terrasse", 10 },
                    { 11, 4, true, "Coin fenêtre", 11 },
                    { 12, 2, true, "Salle principale", 12 },
                    { 13, 4, true, "Salle principale", 13 },
                    { 14, 4, true, "Salle principale", 14 },
                    { 15, 4, false, "Terrasse", 15 },
                    { 16, 4, false, "Coin fenêtre", 16 },
                    { 17, 2, true, "Salle principale", 17 },
                    { 18, 4, true, "Privé", 18 },
                    { 19, 2, false, "Salle principale", 19 },
                    { 20, 8, false, "Salle principale", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}

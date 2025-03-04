using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP2.Migrations
{
    /// <inheritdoc />
    public partial class ReservationsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "GuestCount", "ReservationTime", "Status", "TableId" },
                values: new object[,]
                {
                    { 1, 9, 4, new DateTimeOffset(new DateTime(2025, 1, 16, 4, 50, 40, 921, DateTimeKind.Unspecified).AddTicks(3803), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 13 },
                    { 2, 40, 8, new DateTimeOffset(new DateTime(2025, 1, 4, 18, 28, 25, 352, DateTimeKind.Unspecified).AddTicks(9215), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 3, 1, 8, new DateTimeOffset(new DateTime(2025, 1, 11, 6, 18, 7, 502, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 4, 31, 1, new DateTimeOffset(new DateTime(2025, 1, 26, 0, 34, 29, 691, DateTimeKind.Unspecified).AddTicks(4504), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 1 },
                    { 5, 35, 4, new DateTimeOffset(new DateTime(2025, 1, 22, 15, 24, 55, 656, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 2 },
                    { 6, 41, 1, new DateTimeOffset(new DateTime(2025, 1, 20, 23, 34, 8, 734, DateTimeKind.Unspecified).AddTicks(1829), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 17 },
                    { 7, 4, 6, new DateTimeOffset(new DateTime(2025, 1, 23, 6, 52, 27, 225, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 2 },
                    { 8, 17, 6, new DateTimeOffset(new DateTime(2024, 12, 12, 16, 33, 35, 189, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 9, 22, 8, new DateTimeOffset(new DateTime(2024, 12, 7, 9, 48, 45, 669, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 10, 21, 7, new DateTimeOffset(new DateTime(2024, 12, 1, 7, 11, 20, 523, DateTimeKind.Unspecified).AddTicks(23), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 11, 14, 8, new DateTimeOffset(new DateTime(2024, 12, 31, 12, 1, 35, 422, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 12, 38, 6, new DateTimeOffset(new DateTime(2024, 12, 12, 9, 25, 5, 127, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 7 },
                    { 13, 30, 6, new DateTimeOffset(new DateTime(2025, 1, 2, 17, 54, 35, 952, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 14, 36, 5, new DateTimeOffset(new DateTime(2025, 1, 23, 16, 46, 21, 598, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 2 },
                    { 15, 43, 5, new DateTimeOffset(new DateTime(2025, 1, 24, 23, 45, 37, 485, DateTimeKind.Unspecified).AddTicks(3056), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 16, 33, 6, new DateTimeOffset(new DateTime(2025, 1, 5, 23, 2, 49, 367, DateTimeKind.Unspecified).AddTicks(9525), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 7 },
                    { 17, 42, 3, new DateTimeOffset(new DateTime(2024, 12, 10, 20, 59, 30, 113, DateTimeKind.Unspecified).AddTicks(8565), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 14 },
                    { 18, 21, 2, new DateTimeOffset(new DateTime(2024, 12, 23, 4, 20, 31, 245, DateTimeKind.Unspecified).AddTicks(5787), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 13 },
                    { 19, 21, 8, new DateTimeOffset(new DateTime(2024, 12, 30, 11, 41, 9, 670, DateTimeKind.Unspecified).AddTicks(4837), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 7 },
                    { 20, 9, 8, new DateTimeOffset(new DateTime(2024, 12, 30, 20, 27, 35, 571, DateTimeKind.Unspecified).AddTicks(9167), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 21, 36, 5, new DateTimeOffset(new DateTime(2025, 1, 27, 0, 48, 53, 466, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 22, 17, 2, new DateTimeOffset(new DateTime(2025, 1, 22, 15, 5, 24, 612, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 1 },
                    { 23, 9, 6, new DateTimeOffset(new DateTime(2025, 1, 6, 10, 24, 43, 787, DateTimeKind.Unspecified).AddTicks(9326), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 24, 22, 2, new DateTimeOffset(new DateTime(2024, 12, 21, 7, 11, 48, 467, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 12 },
                    { 25, 18, 4, new DateTimeOffset(new DateTime(2025, 1, 17, 2, 48, 27, 98, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 13 },
                    { 26, 19, 2, new DateTimeOffset(new DateTime(2024, 12, 11, 21, 47, 22, 343, DateTimeKind.Unspecified).AddTicks(3401), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 27, 9, 6, new DateTimeOffset(new DateTime(2025, 1, 23, 16, 39, 45, 187, DateTimeKind.Unspecified).AddTicks(6404), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 28, 46, 7, new DateTimeOffset(new DateTime(2025, 1, 11, 7, 32, 15, 254, DateTimeKind.Unspecified).AddTicks(3585), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 29, 29, 6, new DateTimeOffset(new DateTime(2024, 12, 15, 4, 59, 19, 963, DateTimeKind.Unspecified).AddTicks(7473), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 30, 41, 8, new DateTimeOffset(new DateTime(2025, 1, 25, 7, 38, 17, 229, DateTimeKind.Unspecified).AddTicks(599), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 31, 27, 4, new DateTimeOffset(new DateTime(2025, 1, 21, 21, 26, 41, 270, DateTimeKind.Unspecified).AddTicks(8114), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 32, 40, 6, new DateTimeOffset(new DateTime(2025, 1, 29, 4, 43, 25, 27, DateTimeKind.Unspecified).AddTicks(4258), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 7 },
                    { 33, 7, 8, new DateTimeOffset(new DateTime(2024, 12, 10, 2, 50, 24, 830, DateTimeKind.Unspecified).AddTicks(5234), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 34, 44, 8, new DateTimeOffset(new DateTime(2024, 12, 19, 11, 3, 58, 301, DateTimeKind.Unspecified).AddTicks(6563), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 35, 37, 8, new DateTimeOffset(new DateTime(2024, 12, 10, 20, 1, 26, 555, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 36, 23, 2, new DateTimeOffset(new DateTime(2024, 12, 8, 1, 42, 30, 12, DateTimeKind.Unspecified).AddTicks(1488), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 37, 9, 5, new DateTimeOffset(new DateTime(2025, 1, 23, 9, 44, 46, 192, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 7 },
                    { 38, 44, 8, new DateTimeOffset(new DateTime(2024, 12, 23, 12, 34, 8, 19, DateTimeKind.Unspecified).AddTicks(7313), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 39, 3, 4, new DateTimeOffset(new DateTime(2024, 12, 8, 21, 41, 34, 643, DateTimeKind.Unspecified).AddTicks(9585), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 14 },
                    { 40, 42, 8, new DateTimeOffset(new DateTime(2024, 12, 21, 12, 15, 11, 35, DateTimeKind.Unspecified).AddTicks(308), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 41, 6, 3, new DateTimeOffset(new DateTime(2024, 12, 18, 5, 7, 10, 532, DateTimeKind.Unspecified).AddTicks(4685), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 42, 8, 8, new DateTimeOffset(new DateTime(2024, 12, 3, 8, 26, 53, 764, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 43, 18, 7, new DateTimeOffset(new DateTime(2024, 12, 13, 14, 28, 25, 562, DateTimeKind.Unspecified).AddTicks(1002), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 44, 29, 7, new DateTimeOffset(new DateTime(2025, 1, 31, 15, 5, 50, 409, DateTimeKind.Unspecified).AddTicks(4302), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 7 },
                    { 45, 43, 1, new DateTimeOffset(new DateTime(2024, 12, 3, 8, 13, 7, 157, DateTimeKind.Unspecified).AddTicks(4152), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 13 },
                    { 46, 35, 8, new DateTimeOffset(new DateTime(2025, 1, 7, 16, 13, 47, 895, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 47, 43, 2, new DateTimeOffset(new DateTime(2024, 12, 20, 1, 19, 34, 20, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 12 },
                    { 48, 8, 8, new DateTimeOffset(new DateTime(2025, 1, 26, 1, 40, 6, 900, DateTimeKind.Unspecified).AddTicks(8349), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 49, 17, 8, new DateTimeOffset(new DateTime(2024, 12, 8, 16, 26, 59, 20, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 50, 10, 8, new DateTimeOffset(new DateTime(2025, 1, 4, 23, 57, 33, 828, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 51, 22, 4, new DateTimeOffset(new DateTime(2025, 1, 25, 23, 18, 50, 914, DateTimeKind.Unspecified).AddTicks(4575), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 52, 24, 7, new DateTimeOffset(new DateTime(2024, 12, 7, 12, 22, 25, 676, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 53, 4, 5, new DateTimeOffset(new DateTime(2024, 12, 7, 15, 59, 14, 852, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 2 },
                    { 54, 48, 8, new DateTimeOffset(new DateTime(2024, 12, 21, 16, 15, 53, 197, DateTimeKind.Unspecified).AddTicks(5393), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 55, 48, 6, new DateTimeOffset(new DateTime(2024, 12, 4, 3, 16, 36, 129, DateTimeKind.Unspecified).AddTicks(9877), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 7 },
                    { 56, 48, 8, new DateTimeOffset(new DateTime(2024, 12, 21, 18, 59, 23, 519, DateTimeKind.Unspecified).AddTicks(9508), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 7 },
                    { 57, 43, 6, new DateTimeOffset(new DateTime(2024, 12, 31, 21, 57, 9, 714, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 2 },
                    { 58, 9, 5, new DateTimeOffset(new DateTime(2025, 1, 28, 1, 14, 34, 185, DateTimeKind.Unspecified).AddTicks(7520), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 2 },
                    { 59, 33, 8, new DateTimeOffset(new DateTime(2024, 12, 9, 23, 36, 38, 216, DateTimeKind.Unspecified).AddTicks(517), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 60, 35, 8, new DateTimeOffset(new DateTime(2025, 1, 19, 9, 11, 28, 321, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 61, 29, 2, new DateTimeOffset(new DateTime(2025, 1, 14, 0, 17, 39, 495, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 12 },
                    { 62, 24, 4, new DateTimeOffset(new DateTime(2024, 12, 8, 12, 15, 44, 461, DateTimeKind.Unspecified).AddTicks(2425), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 7 },
                    { 63, 32, 8, new DateTimeOffset(new DateTime(2025, 1, 23, 14, 17, 37, 578, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 64, 13, 3, new DateTimeOffset(new DateTime(2025, 1, 24, 5, 25, 3, 904, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 11 },
                    { 65, 24, 4, new DateTimeOffset(new DateTime(2024, 12, 10, 2, 54, 43, 572, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 7 },
                    { 66, 16, 6, new DateTimeOffset(new DateTime(2025, 1, 19, 1, 50, 6, 640, DateTimeKind.Unspecified).AddTicks(2898), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 67, 24, 8, new DateTimeOffset(new DateTime(2025, 1, 21, 0, 1, 23, 729, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 68, 24, 2, new DateTimeOffset(new DateTime(2024, 12, 11, 9, 15, 39, 874, DateTimeKind.Unspecified).AddTicks(1371), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 1 },
                    { 69, 44, 6, new DateTimeOffset(new DateTime(2024, 12, 3, 2, 38, 30, 965, DateTimeKind.Unspecified).AddTicks(3547), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 70, 28, 2, new DateTimeOffset(new DateTime(2025, 1, 21, 20, 6, 48, 71, DateTimeKind.Unspecified).AddTicks(9436), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 17 },
                    { 71, 45, 8, new DateTimeOffset(new DateTime(2024, 12, 7, 1, 15, 37, 83, DateTimeKind.Unspecified).AddTicks(170), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 72, 12, 8, new DateTimeOffset(new DateTime(2024, 12, 29, 19, 1, 55, 504, DateTimeKind.Unspecified).AddTicks(2401), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 73, 33, 8, new DateTimeOffset(new DateTime(2025, 1, 3, 16, 21, 46, 950, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 74, 16, 5, new DateTimeOffset(new DateTime(2024, 12, 16, 11, 40, 4, 204, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 7 },
                    { 75, 43, 6, new DateTimeOffset(new DateTime(2024, 12, 23, 16, 44, 13, 497, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 2 },
                    { 76, 11, 6, new DateTimeOffset(new DateTime(2025, 1, 23, 0, 29, 35, 256, DateTimeKind.Unspecified).AddTicks(1533), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 2 },
                    { 77, 4, 7, new DateTimeOffset(new DateTime(2025, 1, 14, 10, 14, 7, 567, DateTimeKind.Unspecified).AddTicks(420), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 3 },
                    { 78, 34, 8, new DateTimeOffset(new DateTime(2025, 1, 26, 22, 28, 38, 631, DateTimeKind.Unspecified).AddTicks(2575), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 79, 43, 6, new DateTimeOffset(new DateTime(2025, 1, 12, 1, 49, 37, 714, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 7 },
                    { 80, 35, 5, new DateTimeOffset(new DateTime(2025, 1, 31, 9, 29, 21, 799, DateTimeKind.Unspecified).AddTicks(7940), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 2 },
                    { 81, 11, 8, new DateTimeOffset(new DateTime(2025, 1, 15, 13, 46, 16, 842, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 82, 6, 8, new DateTimeOffset(new DateTime(2024, 12, 20, 20, 27, 43, 699, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 3 },
                    { 83, 39, 7, new DateTimeOffset(new DateTime(2025, 1, 23, 15, 23, 43, 780, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 7 },
                    { 84, 26, 2, new DateTimeOffset(new DateTime(2025, 1, 4, 9, 56, 19, 911, DateTimeKind.Unspecified).AddTicks(341), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 1 },
                    { 85, 20, 2, new DateTimeOffset(new DateTime(2024, 12, 22, 21, 3, 2, 900, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 5 },
                    { 86, 42, 1, new DateTimeOffset(new DateTime(2025, 1, 14, 13, 59, 22, 451, DateTimeKind.Unspecified).AddTicks(553), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 11 },
                    { 87, 30, 3, new DateTimeOffset(new DateTime(2024, 12, 27, 3, 6, 52, 835, DateTimeKind.Unspecified).AddTicks(8267), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 14 },
                    { 88, 19, 5, new DateTimeOffset(new DateTime(2025, 1, 15, 22, 48, 48, 689, DateTimeKind.Unspecified).AddTicks(278), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 7 },
                    { 89, 27, 6, new DateTimeOffset(new DateTime(2025, 1, 21, 6, 14, 53, 842, DateTimeKind.Unspecified).AddTicks(6376), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 2 },
                    { 90, 6, 8, new DateTimeOffset(new DateTime(2025, 1, 27, 14, 39, 37, 129, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 91, 10, 8, new DateTimeOffset(new DateTime(2025, 1, 21, 16, 5, 10, 390, DateTimeKind.Unspecified).AddTicks(3638), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 92, 4, 8, new DateTimeOffset(new DateTime(2025, 1, 11, 0, 21, 18, 64, DateTimeKind.Unspecified).AddTicks(4825), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 93, 24, 3, new DateTimeOffset(new DateTime(2024, 12, 4, 13, 7, 24, 908, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 1 },
                    { 94, 16, 4, new DateTimeOffset(new DateTime(2025, 1, 17, 15, 28, 37, 343, DateTimeKind.Unspecified).AddTicks(5575), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 18 },
                    { 95, 14, 8, new DateTimeOffset(new DateTime(2024, 12, 22, 3, 59, 8, 110, DateTimeKind.Unspecified).AddTicks(7555), new TimeSpan(0, -5, 0, 0, 0)), "En attente", 7 },
                    { 96, 50, 6, new DateTimeOffset(new DateTime(2024, 12, 30, 15, 18, 59, 927, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 7 },
                    { 97, 13, 8, new DateTimeOffset(new DateTime(2024, 12, 10, 12, 23, 11, 866, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 98, 4, 5, new DateTimeOffset(new DateTime(2024, 12, 15, 19, 49, 5, 455, DateTimeKind.Unspecified).AddTicks(8198), new TimeSpan(0, -5, 0, 0, 0)), "Annulée", 3 },
                    { 99, 14, 2, new DateTimeOffset(new DateTime(2025, 1, 12, 19, 38, 49, 885, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 18 },
                    { 100, 49, 5, new DateTimeOffset(new DateTime(2024, 12, 9, 1, 12, 5, 493, DateTimeKind.Unspecified).AddTicks(3377), new TimeSpan(0, -5, 0, 0, 0)), "Confirmée", 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}

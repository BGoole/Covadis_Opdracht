using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovadisLeenAuto.Domain.Migrations
{
    /// <inheritdoc />
    public partial class editedAutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "GereserveerdTot", "Kenteken", "KilometerStand", "Type" },
                values: new object[] { new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "qa-12-30", 500, "BMW M5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "GereserveerdTot", "Kenteken", "KilometerStand", "Type" },
                values: new object[] { new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "mw-99-99", 1010, "Fiat Multipla" });
        }
    }
}

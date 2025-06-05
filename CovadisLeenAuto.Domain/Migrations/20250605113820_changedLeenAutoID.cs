using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovadisLeenAuto.Domain.Migrations
{
    /// <inheritdoc />
    public partial class changedLeenAutoID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "GereserveerdTot", "GereserveerdVan" },
                values: new object[] { new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Gereserveerd", "GereserveerdTot", "GereserveerdVan" },
                values: new object[] { false, new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "LeenAutos",
                columns: new[] { "ID", "Gereserveerd", "GereserveerdTot", "GereserveerdVan", "Kenteken", "KilometerStand", "Type" },
                values: new object[] { 3, true, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "mw-99-99", 1010, "Fiat Multipla" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "GereserveerdTot", "GereserveerdVan" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Gereserveerd", "GereserveerdTot", "GereserveerdVan" },
                values: new object[] { true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}

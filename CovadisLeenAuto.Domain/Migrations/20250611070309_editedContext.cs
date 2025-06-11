using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CovadisLeenAuto.Domain.Migrations
{
    /// <inheritdoc />
    public partial class editedContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "GereserveerdTot",
                table: "LeenAutos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GereserveerdVan",
                table: "LeenAutos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Gereserveerd", "GereserveerdTot", "GereserveerdVan" },
                values: new object[] { true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "GereserveerdTot", "GereserveerdVan" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Werknemers",
                columns: new[] { "ID", "Naam" },
                values: new object[,]
                {
                    { 1, "Mathijs" },
                    { 2, "Benny" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Werknemers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Werknemers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "GereserveerdTot",
                table: "LeenAutos");

            migrationBuilder.DropColumn(
                name: "GereserveerdVan",
                table: "LeenAutos");

            migrationBuilder.UpdateData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 1,
                column: "Gereserveerd",
                value: false);
        }
    }
}

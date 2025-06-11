using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CovadisLeenAuto.Domain.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeenAutos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Kenteken = table.Column<string>(type: "TEXT", nullable: false),
                    Gereserveerd = table.Column<bool>(type: "INTEGER", nullable: false),
                    GereserveerdVan = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GereserveerdTot = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KilometerStand = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeenAutos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Werknemers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werknemers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ritten",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WerknemerID = table.Column<int>(type: "INTEGER", nullable: false),
                    KilometerStandBegin = table.Column<int>(type: "INTEGER", nullable: false),
                    KilometerStandEind = table.Column<int>(type: "INTEGER", nullable: false),
                    BeginDatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EindDatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartAdres = table.Column<string>(type: "TEXT", nullable: false),
                    EindAdres = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ritten", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ritten_Werknemers_WerknemerID",
                        column: x => x.WerknemerID,
                        principalTable: "Werknemers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LeenAutos",
                columns: new[] { "ID", "Gereserveerd", "GereserveerdTot", "GereserveerdVan", "Kenteken", "KilometerStand", "Type" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "aa11bc2", 1234, "Honda Civic" },
                    { 2, false, new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mw-99-99", 1010, "Fiat Multipla" },
                    { 3, true, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "qa-12-30", 500, "BMW M5" }
                });

            migrationBuilder.InsertData(
                table: "Werknemers",
                columns: new[] { "ID", "Naam" },
                values: new object[,]
                {
                    { 1, "Mathijs" },
                    { 2, "Emilio" },
                    { 3, "Juan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ritten_WerknemerID",
                table: "Ritten",
                column: "WerknemerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeenAutos");

            migrationBuilder.DropTable(
                name: "Ritten");

            migrationBuilder.DropTable(
                name: "Werknemers");
        }
    }
}

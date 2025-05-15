using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovadisLeenAuto.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                columns: new[] { "ID", "Gereserveerd", "Kenteken", "KilometerStand", "Type" },
                values: new object[] { 1, false, "aa11bc2", 1234, "Honda Civic" });

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
